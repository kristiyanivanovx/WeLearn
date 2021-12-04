using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Enums;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.ViewModels.Admin.Lesson;
using WeLearn.Web.ViewModels.Interfaces;
using WeLearn.Web.ViewModels.Lesson;

using static WeLearn.Data.Common.Validation.DataValidation.Material;
using static WeLearn.Data.Common.Validation.DataValidation.Video;

namespace WeLearn.Services
{
    public class LessonsService : ILessonsService
    {
        private readonly IDeletableEntityRepository<Data.Models.Video> videoRepository;
        private readonly IDeletableEntityRepository<Data.Models.Material> materialRepository;
        private readonly IDeletableEntityRepository<Data.Models.Lesson> lessonRepository;
        private readonly IInputOutputService inputOutputService;

        private const string InvalidFileSizeMessage =
            "There was an error with the upload of one of the files. " +
            "Contact us or check whether all of your file formats are supported and if their sizes are acceptable.";

        private const string InvalidVideoExtensionOrSizeMessage =
            "There was an error with the video upload. Contact us or check whether your video format is supported and the size is acceptable.";

        private const string CloudinaryZipFilesFolder = "welearn-asp-net-core-app/zip-files/";

        private const string CloudinaryVideosFolder = "welearn-asp-net-core-app/videos/";

        public LessonsService(
            IDeletableEntityRepository<Data.Models.Video> videoRepository,
            IDeletableEntityRepository<Data.Models.Material> materialRepository,
            IDeletableEntityRepository<Data.Models.Lesson> lessonRepository,
            IInputOutputService inputOutputService)
        {
            this.videoRepository = videoRepository;
            this.materialRepository = materialRepository;
            this.lessonRepository = lessonRepository;
            this.inputOutputService = inputOutputService;
        }

        public int GetAllLessonsCount() => this.lessonRepository.All().Count();

        public async Task<T> GetLessonByIdAsync<T>(int id)
            => await this.lessonRepository
                .All()
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task<T> GetLessonByIdWithDeletedAsync<T>(int id)
            => await this.lessonRepository
                .AllWithDeleted()
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .To<T>()
                .FirstOrDefaultAsync();

        public async Task<IEnumerable<LessonViewModel>> GetLessonsByCategoryAndGradeAsync(
            string categoryName,
            string searchString,
            int grade)
        {
            IQueryable<Lesson> lessonsByCategory =
                this.lessonRepository.All().Where(x => x.Category.Name == categoryName && x.IsApproved);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessonsByCategory = lessonsByCategory.Where(x =>
                    x.Name.ToLower().Contains(searchString.ToLower()) ||
                    x.Description.ToLower().Contains(searchString.ToLower()));
            }

            if (grade != -1)
            {
                lessonsByCategory = lessonsByCategory.Where(x => x.Grade == (Grade)grade);
            }

            var lessons = await lessonsByCategory
                .Include(x => x.Video)
                .Include(x => x.Material)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .To<LessonViewModel>()
                .ToListAsync();

            return lessons;
        }

        public async Task<IEnumerable<T>> GetAllLessonsAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons =
                this.lessonRepository.All().Where(x => x.IsApproved);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            var models = await lessons
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .To<T>()
                .ToListAsync();

            return models;
        }

        public async Task<IEnumerable<T>> GetAllLessonsWithDeletedAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons = this.lessonRepository.AllWithDeleted();

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            var mapped = await lessons
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .To<T>()
                .ToListAsync();

            return mapped;
        }

        public async Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId, string searchString)
        {
            IQueryable<Lesson> lessons = this.lessonRepository.All();

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            List<LessonViewModel> lessonsByMe = await lessons
                .Where(x => x.ApplicationUserId == userId)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .To<LessonViewModel>()
                .ToListAsync();

            return lessonsByMe;
        }

        public async Task SoftDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = this.lessonRepository.All().FirstOrDefault(x => x.Id == lessonId);
            this.lessonRepository.Delete(lesson);
            await this.lessonRepository.SaveChangesAsync();
        }

        public async Task HardDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = this.lessonRepository.AllWithDeleted()
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefault(x => x.Id == lessonId);

            if (lesson?.Video.PublicId != null && lesson.Material.PublicId != null)
            {
                Cloudinary cloudinary = new Cloudinary();
                DelResResult deleteMaterialResult = await cloudinary.DeleteResourcesAsync(lesson.Video.PublicId);
                DelResResult deleteVideoResult = await cloudinary.DeleteResourcesAsync(lesson.Material.PublicId);
            }

            this.videoRepository.HardDelete(lesson?.Video);
            this.materialRepository.HardDelete(lesson?.Material);

            await this.videoRepository.SaveChangesAsync();
            await this.materialRepository.SaveChangesAsync();

            this.lessonRepository.HardDelete(lesson);
            await this.lessonRepository.SaveChangesAsync();
        }

        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task CreateLessonAsync(
            LessonInputModel lessonInputModel,
            string environmentWebRootPath,
            bool isDevelopment,
            string userId)
        {
            // Lesson lesson = this.mapper.Map<LessonInputModel, Lesson>(lessonInputModel);
            Lesson lesson = new Lesson
            {
                Name = lessonInputModel.LessonName,
                Grade = lessonInputModel.Grade,
                Description = lessonInputModel.Description,
                CategoryId = lessonInputModel.CategoryId,
                ApplicationUserId = userId
            };

            await this.lessonRepository.AddAsync(lesson);
            await this.lessonRepository.SaveChangesAsync();

            await this.CreateLessonBasedOnEnvironmentAsync(
                lessonInputModel,
                environmentWebRootPath,
                isDevelopment,
                lesson);

            await this.lessonRepository.SaveChangesAsync();
        }

        public async Task EditLessonAsync(
            LessonEditModel lessonEditModel,
            string environmentWebRootPath,
            bool isDevelopment,
            string userId)
        {
            Lesson lesson = await this.FindLessonAsync(lessonEditModel);
            UpdateEntityProperties(lessonEditModel, lesson);

            await this.UpdateVideoAndFilesBasedOnEnvironmentAsync(
                lessonEditModel,
                environmentWebRootPath,
                isDevelopment,
                lesson);

            await this.lessonRepository.SaveChangesAsync();
        }

        public async Task EditLessonAdministrationAsync(AdminLessonEditModel model)
        {
            Lesson entity = this.lessonRepository.AllWithDeleted().FirstOrDefault(x => x.Id == model.Id);

            if (entity != null)
            {
                entity.Name = model.Name ?? entity.Name;
                entity.Description = model.Description ?? entity.Description;
                entity.CategoryId = model.CategoryId;
                entity.Grade = model.Grade;
                entity.IsApproved = model.IsApproved;

                if (model.IsDeleted)
                {
                    this.lessonRepository.Delete(entity);
                }
                else
                {
                    this.lessonRepository.Undelete(entity);
                }
            }

            await this.lessonRepository.SaveChangesAsync();
        }

        private async Task UpdateVideoAndFilesBasedOnEnvironmentAsync(
            LessonEditModel lessonEditModel,
            string environmentWebRootPath,
            bool isDevelopment,
            Lesson lesson)
        {
            string stringGuid = Guid.NewGuid().ToString();
            string uploadsMaterialsPath =
                this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "materials");
            string filesPath = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

            if (isDevelopment)
            {
                await this.UpdateVideoInDevelopment(lessonEditModel, environmentWebRootPath, lesson);
                await this.UpdateFilesInDevelopment(lessonEditModel, lesson, filesPath);
            }
            else
            {
                await this.UpdateVideoInProduction(lessonEditModel, lesson);
                await this.UpdateFilesInProduction(lessonEditModel, lesson);
            }
        }

        private async Task UpdateVideoInProduction(LessonEditModel lessonEditModel, Lesson lesson)
        {
            if (lessonEditModel.Video != null)
            {
                Cloudinary cloudinary = new Cloudinary();
                Data.Models.Video previousVideoEntity = lesson.Video;

                DelResResult result = await cloudinary.DeleteResourcesAsync(previousVideoEntity.PublicId);
                this.videoRepository.HardDelete(previousVideoEntity);
                await this.videoRepository.SaveChangesAsync();

                Data.Models.Video newVideoEntity = await this.UploadVideoCloudinaryAsync(lesson, lessonEditModel);

                await this.videoRepository.SaveChangesAsync();
                lesson.VideoId = newVideoEntity.Id;
            }
        }

        private async Task UpdateFilesInProduction(LessonEditModel lessonEditModel, Lesson lesson)
        {
            if (lessonEditModel.Files != null)
            {
                Cloudinary cloudinary = new Cloudinary();
                Material previousMaterialEntity = lesson.Material;

                RawUploadResult materialUploadResult = await this.UploadMaterialsCloudinaryAsync(lessonEditModel);

                string path = materialUploadResult.SecureUrl.AbsoluteUri;
                string name = Guid.NewGuid().ToString();
                string publicId = materialUploadResult.PublicId;

                DelResResult result = await cloudinary.DeleteResourcesAsync(previousMaterialEntity.PublicId);
                this.materialRepository.Delete(previousMaterialEntity);
                await this.materialRepository.SaveChangesAsync();

                Material materialEntity = await this.AddMaterialToDatabaseAsync(lesson, path, name, publicId);
                await this.materialRepository.SaveChangesAsync();

                lesson.MaterialId = materialEntity.Id;
            }
        }

        private async Task CreateLessonBasedOnEnvironmentAsync(
            LessonInputModel lessonInputModel,
            string environmentWebRootPath,
            bool isDevelopment,
            Lesson lesson)
        {
            Data.Models.Video videoEntity;
            Material materialEntity;

            if (isDevelopment)
            {
                int lessonId = lesson.Id;
                string stringGuid = Guid.NewGuid().ToString();
                string uploadsMaterialsPath =
                    this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "materials");
                string filesPath = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

                await this.UploadMaterialsAsync(lessonInputModel, filesPath);

                materialEntity = await this.AddMaterialToDatabaseAsync(lesson, filesPath, stringGuid, null);
                videoEntity = await this.UploadVideoAsync(lesson, lessonInputModel, environmentWebRootPath);
            }
            else
            {
                Cloudinary cloudinary = new Cloudinary();
                RawUploadResult materialUploadResult = await this.UploadMaterialsCloudinaryAsync(lessonInputModel);

                string path = materialUploadResult.SecureUrl.AbsoluteUri;
                string name = Guid.NewGuid().ToString();
                string publicId = materialUploadResult.PublicId;

                materialEntity = await this.AddMaterialToDatabaseAsync(lesson, path, name, publicId);
                videoEntity = await this.UploadVideoCloudinaryAsync(lesson, lessonInputModel);

                await this.lessonRepository.SaveChangesAsync();
            }

            lesson.VideoId = videoEntity.Id;
            lesson.MaterialId = materialEntity.Id;
        }

        private async Task UpdateFilesInDevelopment(LessonEditModel lessonEditModel, Lesson lesson, string path)
        {
            if (lessonEditModel.Files != null)
            {
                string stringGuid = Guid.NewGuid().ToString();
                await this.UploadMaterialsAsync(lessonEditModel, path);
                Material materialEntity = await this.AddMaterialToDatabaseAsync(lesson, path, stringGuid, null);
                lesson.MaterialId = materialEntity.Id;
                await this.materialRepository.SaveChangesAsync();
            }
        }

        private async Task UpdateVideoInDevelopment(
            LessonEditModel lessonEditModel,
            string environmentWebRootPath,
            Lesson lesson)
        {
            if (lessonEditModel.Video != null)
            {
                Data.Models.Video videoEntity = await this.UploadVideoAsync(lesson, lessonEditModel, environmentWebRootPath);
                lesson.VideoId = videoEntity.Id;
                await this.lessonRepository.SaveChangesAsync();
            }
        }

        private async Task<Lesson> FindLessonAsync(LessonEditModel lessonEditModel)
            => await this.lessonRepository
                .All()
                .Include(x => x.Material)
                .Include(x => x.Video)
                .FirstOrDefaultAsync(x => x.Id == lessonEditModel.LessonId);

        private static void UpdateEntityProperties(LessonEditModel lessonEditModel, Lesson entity)
        {
            entity.Name = lessonEditModel.Name ?? entity.Name;
            entity.Description = lessonEditModel.Description ?? entity.Description;
            entity.CategoryId = lessonEditModel.CategoryId;
            entity.Grade = lessonEditModel.Grade;
        }

        private async Task<Data.Models.Video> UploadVideoCloudinaryAsync(Lesson lesson, ILessonModel lessonInputModel)
        {
            Cloudinary cloudinary = new Cloudinary();
            IFormFile video = lessonInputModel.Video;
            bool isVideoExtensionAllowed = AllowedVideoExtensions.Any(extension => video.FileName.EndsWith(extension));
            bool isVideoWithAcceptableSize =
                video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            bool isVideoAcceptable = isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            using MemoryStream videoStream = new MemoryStream();
            await video.OpenReadStream().CopyToAsync(videoStream);
            videoStream.Position = 0;

            VideoUploadParams uploadParams = GenerateVideoUploadParams(videoStream, video);
            VideoUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);

            string path = uploadResult.SecureUrl.AbsoluteUri;
            string publicId = uploadParams.PublicId;
            Data.Models.Video videoEntity = CreateVideoEntity(lesson, video, path, publicId);

            await this.videoRepository.AddAsync(videoEntity);

            // await this.context.SaveChangesAsync();
            return videoEntity;
        }

        public async Task UploadMaterialsAsync(ILessonModel lessonInputModel, string path)
        {
            // check if the sum of files' sizes is above 0 mb and below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll =
                lessonInputModel.Files.Sum(x => x.Length) > MinimumZipFileSizeInBytes &&
                lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;

            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file =>
                AllowedFileExtensions.Any(extension => file.FileName.EndsWith(extension)));

            bool areFilesValid = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesValid)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            await using FileStream fileStream = File.Create(path);
            await using Stream files = await this.inputOutputService.ArchiveFilesAsync(lessonInputModel.Files);
            files.Seek(0, SeekOrigin.Begin);
            files.CopyTo(fileStream);
        }

        public async Task<Data.Models.Video> UploadVideoAsync(
            Lesson lesson,
            ILessonModel lessonInputModel,
            string environmentWebRootPath)
        {
            IFormFile video = lessonInputModel.Video;
            bool isVideoExtensionAllowed = AllowedVideoExtensions.Any(x => video.FileName.EndsWith(x));
            bool isVideoWithAcceptableSize =
                video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;

            bool isVideoAcceptable = isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            string uniqueFileNameVideo = this.inputOutputService.GetUniqueFileName(video.FileName);
            string uploadsVideos =
                this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "videos");

            string videoPath = this.inputOutputService.GenerateItemPath("\\uploads", "videos", uniqueFileNameVideo);

            string fullFilePath = Path.Combine(uploadsVideos, uniqueFileNameVideo);
            using (FileStream stream = new FileStream(fullFilePath, FileMode.Create))
            {
                await video.CopyToAsync(stream);
            }

            Data.Models.Video videoEntity = CreateVideoEntity(lesson, video, videoPath, null);

            await this.videoRepository.AddAsync(videoEntity);
            await this.videoRepository.SaveChangesAsync();

            return videoEntity;
        }

        private async Task<RawUploadResult> UploadMaterialsCloudinaryAsync(ILessonModel lessonInputModel)
        {
            Cloudinary cloudinary = new Cloudinary();

            // check if the sum of files' sizes is above 0 mb, below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll =
                lessonInputModel.Files.Sum(file => file.Length) > MinimumZipFileSizeInBytes &&
                lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;

            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file =>
                AllowedFileExtensions.Any(extension => file.FileName.EndsWith(extension)));

            bool areFilesAcceptable = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesAcceptable)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            string name = Guid.NewGuid().ToString();

            using Stream files = await this.inputOutputService.ArchiveFilesAsync(lessonInputModel.Files);
            RawUploadParams uploadParams = GenerateRawUploadParam(files, name);
            RawUploadResult uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult;
        }

        private static VideoUploadParams GenerateVideoUploadParams(MemoryStream videoStream, IFormFile video)
            => new VideoUploadParams()
            {
                File = new FileDescription(@$"{video.FileName}", videoStream),
                PublicId = video.FileName,
                Folder = CloudinaryVideosFolder,
                Overwrite = true,
                UniqueFilename = true,
            };

        private static RawUploadParams GenerateRawUploadParam(Stream files, string name)
            => new RawUploadParams()
            {
                File = new FileDescription(@$"{name}.zip", files),
                PublicId = name,
                Folder = CloudinaryZipFilesFolder,
                Overwrite = true,
                UniqueFilename = false,
            };

        private static Material CreateMaterial(Lesson lesson, string path, string stringGuid, string publicId = null)
            => new Material
            {
                Name = stringGuid,
                Link = path,
                PublicId = publicId,
                Lesson = lesson
            };

        private static Data.Models.Video CreateVideoEntity(
            Lesson lesson,
            IFormFile video,
            string path,
            string publicId = null)
        {
            return new Data.Models.Video
            {
                Name = video.FileName,
                ContentType = video.ContentType,
                Link = path,
                PublicId = publicId,
                Lesson = lesson
            };
        }

        private async Task<Material> AddMaterialToDatabaseAsync(
            Lesson lesson,
            string path,
            string stringGuid,
            string publicId = null)
        {
            Material materialEntity = CreateMaterial(lesson, path, stringGuid, publicId);
            await this.materialRepository.AddAsync(materialEntity);
            await this.materialRepository.SaveChangesAsync();

            return materialEntity;
        }
    }
}