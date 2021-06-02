using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.ViewModels.Interfaces;
using WeLearn.ViewModels;
using WeLearn.Services.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using static WeLearn.Data.Infrastructure.DataValidation.Video;
using static WeLearn.Data.Infrastructure.DataValidation.Material;
using WeLearn.ViewModels.Lesson;
using WeLearn.ViewModels.Admin;
using WeLearn.ViewModels.Admin.Lesson;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Services
{
    public class LessonsService : ILessonsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IInputOutputService inputOutputService;

        private const string InvalidFileSizeMessage = 
            "There was an error with the upload of one of the files. " +
            "Contact us or check whether all of your file formats are supported and if their sizes are acceptable.";

        private const string InvalidVideoExtensionOrSizeMessage =
            "There was an error with the video upload. Contact us or check whether your video format is supported and the size is acceptable.";

        private const string CloudinaryZipFilesFolder = "welearn-asp-net-core-app/zip-files/";

        private const string CloudinaryVideosFolder = "welearn-asp-net-core-app/videos/";

        public LessonsService(ApplicationDbContext context, IMapper mapper, IInputOutputService inputOutputService)
        {
            this.context = context;
            this.mapper = mapper;
            this.inputOutputService = inputOutputService;
        }

        public int GetAllLessonsCount() => this.context.Lessons.Count();

        public async Task<T> GetLessonByIdAsync<T>(int id)
        {
            Lesson lesson = await this.context.Lessons
                .Where(x => x.Id == id && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            T lessonMapped = this.mapper.Map<T>(lesson);
            return lessonMapped;
        }

        public async Task<T> GetLessonByIdAdministrationAsync<T>(int id)
        {
            Lesson lesson = await this.context.Lessons
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            T lessonMapped = this.mapper.Map<T>(lesson);
            return lessonMapped;
        }

        public async Task<IEnumerable<LessonViewModel>> GetLessonsByCategoryAndGradeAsync(string categoryName, string searchString, int grade)
        {
            IQueryable<Lesson> lessonsByCategory = this.context.Lessons.Where(x => x.Category.Name == categoryName && !x.IsDeleted && x.IsApproved);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessonsByCategory = lessonsByCategory.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                                                 x.Description.ToLower().Contains(searchString.ToLower()));
            }

            if (grade != -1)
            {
                lessonsByCategory = lessonsByCategory.Where(x => x.Grade == (Grade) grade);
            }

            await lessonsByCategory
                .Include(x => x.Video)
                .Include(x => x.Material)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            LessonViewModel[] lessonsMapped = this.mapper.Map<LessonViewModel[]>(lessonsByCategory);
            return lessonsMapped;
        }

        public async Task<IEnumerable<T>> GetAllLessonsAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons = this.context.Lessons.Where(x => !x.IsDeleted && x.IsApproved);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) || 
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            await lessons
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            T[] lessonsViewModel = this.mapper.Map<T[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<T>> GetAllLessonsAdministrationAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons = this.context.Lessons;

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            await lessons
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            T[] lessonsViewModel = this.mapper.Map<T[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId, string searchString)
        {
            IQueryable<Lesson> lessons = this.context.Lessons;

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            List<Lesson> lessonsByMe = await lessons
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            LessonViewModel[] lessonsByMeMapped = this.mapper.Map<LessonViewModel[]>(lessonsByMe);
            return lessonsByMeMapped;
        }

        public async Task SoftDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = this.context.Lessons.FirstOrDefault(x => x.Id == lessonId);
            lesson.IsDeleted = true;
            await this.context.SaveChangesAsync();
        }

        public async Task HardDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = this.context.Lessons
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefault(x => x.Id == lessonId);

            Cloudinary cloudinary = new Cloudinary();

            if (lesson.Video.PublicId != null && lesson.Material.PublicId != null)
            {
                DelResResult deleteMaterialResult = await cloudinary.DeleteResourcesAsync(lesson.Video.PublicId);
                DelResResult deleteVideoResult = await cloudinary.DeleteResourcesAsync(lesson.Material.PublicId);
            }

            this.context.Videos.Remove(lesson.Video);
            this.context.Materials.Remove(lesson.Material);
            await this.context.SaveChangesAsync();

            this.context.Lessons.Remove(lesson);
            await this.context.SaveChangesAsync();
        }

        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task CreateLessonAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, bool isDevelopment, string userId)
        {
            Lesson lesson = this.mapper.Map<LessonInputModel, Lesson>(lessonInputModel);
            lesson.ApplicationUserId = userId;
            await this.context.Lessons.AddAsync(lesson);
            await this.context.SaveChangesAsync();

            await CreateLessonBasedOnEnvironmentAsync(lessonInputModel, environmentWebRootPath, isDevelopment, lesson);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLessonAsync(LessonEditModel lessonEditModel, string environmentWebRootPath, bool isDevelopment, string userId)
        {
            Lesson lesson = await FindLessonAsync(lessonEditModel);
            UpdateEntityProperties(lessonEditModel, lesson);
            await UpdateVideoAndFilesBasedOnEnvironmentAsync(lessonEditModel, environmentWebRootPath, isDevelopment, lesson);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLessonAdministrationAsync(AdminLessonEditModel model)
        {
            Lesson entity = this.context.Lessons.FirstOrDefault(x => x.Id == model.Id);

            entity.Name = model.Name ?? entity.Name;
            entity.Description = model.Description ?? entity.Description;
            entity.CategoryId = model.CategoryId;
            entity.Grade = model.Grade;
            entity.DateCreated = model.DateCreated;
            entity.IsDeleted = model.IsDeleted;
            entity.IsApproved = model.IsApproved;

            await this.context.SaveChangesAsync();
        }

        private async Task UpdateVideoAndFilesBasedOnEnvironmentAsync(LessonEditModel lessonEditModel, string environmentWebRootPath, bool isDevelopment, Lesson lesson)
        {
            string stringGuid = Guid.NewGuid().ToString();
            string uploadsMaterialsPath = this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "materials");
            string filesPath = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

            if (isDevelopment)
            {
                await UpdateVideoInDevelopment(lessonEditModel, environmentWebRootPath, lesson);
                await UpdateFilesInDevelopment(lessonEditModel, lesson, filesPath);
            }
            else
            {
                await UpdateVideoInProduction(lessonEditModel, lesson);
                await UpdateFilesInProduction(lessonEditModel, lesson);
            }
        }

        private async Task UpdateVideoInProduction(LessonEditModel lessonEditModel, Lesson lesson)
        {
            if (lessonEditModel.Video != null)
            {
                Cloudinary cloudinary = new Cloudinary();
                Data.Models.Video previousVideoEntity = lesson.Video;
                
                DelResResult result = await cloudinary.DeleteResourcesAsync(previousVideoEntity.PublicId);
                this.context.Remove(previousVideoEntity);
                await this.context.SaveChangesAsync();

                Data.Models.Video newVideoEntity = await UploadVideoCloudinaryAsync(lesson, lessonEditModel);

                await this.context.SaveChangesAsync();
                lesson.VideoId = newVideoEntity.Id;
            }
        }

        private async Task UpdateFilesInProduction(LessonEditModel lessonEditModel, Lesson lesson)
        {
            if (lessonEditModel.Files != null)
            {
                Cloudinary cloudinary = new Cloudinary();
                Material previousMaterialEntity = lesson.Material;

                RawUploadResult materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonEditModel);

                string path = materialUploadResult.SecureUrl.AbsoluteUri;
                string name = Guid.NewGuid().ToString();
                string publicId = materialUploadResult.PublicId;

                DelResResult result = await cloudinary.DeleteResourcesAsync(previousMaterialEntity.PublicId);
                this.context.Remove(previousMaterialEntity);
                await context.SaveChangesAsync();

                Material materialEntity = await AddMaterialToDatabaseAsync(lesson, path, name, publicId);
                await this.context.SaveChangesAsync();

                lesson.MaterialId = materialEntity.Id;
            }
        }

        private async Task CreateLessonBasedOnEnvironmentAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, bool isDevelopment, Lesson lesson)
        {
            Data.Models.Video videoEntity;
            Material materialEntity;

            if (isDevelopment)
            {
                int lessonId = lesson.Id;
                string stringGuid = Guid.NewGuid().ToString();
                string uploadsMaterialsPath = this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "materials");
                string filesPath = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

                await UploadMaterialsAsync(lessonInputModel, filesPath);

                materialEntity = await AddMaterialToDatabaseAsync(lesson, filesPath, stringGuid, null);
                videoEntity = await UploadVideoAsync(lesson, lessonInputModel, environmentWebRootPath);
            }
            else
            {
                Cloudinary cloudinary = new Cloudinary();
                RawUploadResult materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonInputModel);

                string path = materialUploadResult.SecureUrl.AbsoluteUri;
                string name = Guid.NewGuid().ToString();
                string publicId = materialUploadResult.PublicId;

                materialEntity = await AddMaterialToDatabaseAsync(lesson, path, name, publicId);
                videoEntity = await UploadVideoCloudinaryAsync(lesson, lessonInputModel);

                await this.context.SaveChangesAsync();
            }

            lesson.VideoId = videoEntity.Id;
            lesson.MaterialId = materialEntity.Id;
            lesson.DateCreated = DateTime.UtcNow;
        }

        private async Task UpdateFilesInDevelopment(LessonEditModel lessonEditModel, Lesson lesson, string path)
        {
            if (lessonEditModel.Files != null)
            {
                string stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(lessonEditModel, path);
                Material materialEntity = await AddMaterialToDatabaseAsync(lesson, path, stringGuid, null);
                lesson.MaterialId = materialEntity.Id;
                await this.context.SaveChangesAsync();
            }
        }

        private async Task UpdateVideoInDevelopment(LessonEditModel lessonEditModel, string environmentWebRootPath, Lesson lesson)
        {
            if (lessonEditModel.Video != null)
            {
                Data.Models.Video videoEntity = await UploadVideoAsync(lesson, lessonEditModel, environmentWebRootPath);
                lesson.VideoId = videoEntity.Id;
                await this.context.SaveChangesAsync();
            }
        }

        private async Task<Lesson> FindLessonAsync(LessonEditModel lessonEditModel)
            => await this.context.Lessons
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
            bool isVideoWithAcceptableSize = video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            bool isVideoAcceptable = video != null && isVideoExtensionAllowed && isVideoWithAcceptableSize;

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

            await this.context.Videos.AddAsync(videoEntity);
            //await this.context.SaveChangesAsync();
            return videoEntity;
        }

        public async Task UploadMaterialsAsync(ILessonModel lessonInputModel, string path)
        {
            // check if the sum of files' sizes is above 0 mb and below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(x => x.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFileExtensions.Any(extension => file.FileName.EndsWith(extension)));
            bool areFilesValid = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesValid)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            using (FileStream fileStream = File.Create(path))
            {
                using Stream files = await this.inputOutputService.ArchiveFilesAsync(lessonInputModel.Files);
                files.Seek(0, SeekOrigin.Begin);
                files.CopyTo(fileStream);
            }
        }

        public async Task<Data.Models.Video> UploadVideoAsync(Lesson lesson, ILessonModel lessonInputModel, string environmentWebRootPath)
        {
            IFormFile video = lessonInputModel.Video;
            bool isVideoExtensionAllowed = AllowedVideoExtensions.Any(x => video.FileName.EndsWith(x));
            bool isVideoWithAcceptableSize = video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            bool isVideoAcceptable = video != null && isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            string uniqueFileNameVideo = this.inputOutputService.GetUniqueFileName(video.FileName);
            string uploadsVideos = this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "videos");
            string videoPath = this.inputOutputService.GenerateItemPath("\\uploads", "videos", uniqueFileNameVideo);

            string fullFilePath = Path.Combine(uploadsVideos, uniqueFileNameVideo);
            using (FileStream stream = new FileStream(fullFilePath, FileMode.Create))
            {
                await video.CopyToAsync(stream);
            }

            Data.Models.Video videoEntity = CreateVideoEntity(lesson, video, videoPath, null);

            await this.context.Videos.AddAsync(videoEntity);
            await this.context.SaveChangesAsync();

            return videoEntity;
        }

        private async Task<RawUploadResult> UploadMaterialsCloudinaryAsync(ILessonModel lessonInputModel)
        {
            Cloudinary cloudinary = new Cloudinary();

            // check if the sum of files' sizes is above 0 mb, below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(file => file.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFileExtensions.Any(extension => file.FileName.EndsWith(extension)));
            bool areFilesAcceptable = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesAcceptable)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            string name = Guid.NewGuid().ToString();

            using Stream files = await inputOutputService.ArchiveFilesAsync(lessonInputModel.Files);
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
                    DateCreated = DateTime.UtcNow,
                    Link = path,
                    PublicId = publicId,
                    Lesson = lesson
                };


        private static Data.Models.Video CreateVideoEntity(Lesson lesson, IFormFile video, string path, string publicId = null)
            => new Data.Models.Video
            {
                Name = video.FileName,
                ContentType = video.ContentType,
                DateCreated = DateTime.UtcNow,
                Link = path,
                PublicId = publicId,
                Lesson = lesson
            };

        private async Task<Material> AddMaterialToDatabaseAsync(Lesson lesson, string path, string stringGuid, string publicId = null)
        {
            Material materialEntity = CreateMaterial(lesson, path, stringGuid, publicId);
            await this.context.Materials.AddAsync(materialEntity);
            //await this.context.SaveChangesAsync();
            return materialEntity;
        }
    }
}
