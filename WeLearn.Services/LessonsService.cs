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
using static WeLearn.Data.DataValidation.Video;
using static WeLearn.Data.DataValidation.Material;

namespace WeLearn.Services
{
    public class LessonsService : ILessonsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IArchiveService archiveService;

        private const string InvalidFileSizeMessage = 
            "There was an error with the upload of one of the files. " +
            "Contact us or check whether all of your file formats are supported and if their sizes are acceptable.";

        private const string InvalidVideoExtensionOrSizeMessage =
            "There was an error with the video upload. Contact us or check whether your video format is supported and the size is acceptable.";

        public LessonsService(
            ApplicationDbContext context, 
            IMapper mapper, 
            IArchiveService archiveService)
        {
            this.context = context;
            this.mapper = mapper;
            this.archiveService = archiveService;
        }

        public async Task<int> GetAllLessonsCountAsync()
        {
            return await context.Lessons.CountAsync();
        }

        public async Task<T> GetLessonByIdAsync<T>(int id)
        {
            Lesson lesson = await context.Lessons
                .Where(x => x.Id == id && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            T lessonMapped = mapper.Map<T>(lesson);
            return lessonMapped;
        }

        public async Task<T> GetLessonByIdAdministrationAsync<T>(int id)
        {
            Lesson lesson = await context.Lessons
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            T lessonMapped = mapper.Map<T>(lesson);
            return lessonMapped;
        }

        public async Task<IEnumerable<LessonViewModel>> GetAllLessonsByCategoryAsync(string categoryName, string searchString)
        {
            IQueryable<Lesson> lessonsByCategory = context.Lessons.Where(x => x.Category.Name == categoryName && !x.IsDeleted && x.IsApproved);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessonsByCategory = lessonsByCategory.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                                                 x.Description.ToLower().Contains(searchString.ToLower()));
            }

            await lessonsByCategory
                .Include(x => x.Video)
                .Include(x => x.Material)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .ToListAsync();

            LessonViewModel[] lessonsMapped = mapper.Map<LessonViewModel[]>(lessonsByCategory);
            return lessonsMapped;
        }

        public async Task<IEnumerable<T>> GetAllLessonsAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons = context.Lessons.Where(x => !x.IsDeleted && x.IsApproved);

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

            T[] lessonsViewModel = mapper.Map<T[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<T>> GetAllLessonsAdministrationAsync<T>(string searchString)
        {
            IQueryable<Lesson> lessons = context.Lessons;

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

            T[] lessonsViewModel = mapper.Map<T[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId)
        {
            List<Lesson> lessonsByMe = await context.Lessons
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            LessonViewModel[] lessonsByMeMapped = mapper.Map<LessonViewModel[]>(lessonsByMe);
            return lessonsByMeMapped;
        }

        public async Task SoftDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = context.Lessons.FirstOrDefault(x => x.Id == lessonId);
            lesson.IsDeleted = true;
            await context.SaveChangesAsync();
        }

        public async Task HardDeleteLessonByIdAsync(int lessonId)
        {
            Lesson lesson = context.Lessons.FirstOrDefault(x => x.Id == lessonId);
            context.Lessons.Remove(lesson);
            await context.SaveChangesAsync();
        }

        [RequestSizeLimit(MaximumVideoSizeInBytes)]
        public async Task CreateLessonAsync(
            LessonInputModel lessonInputModel, dynamic environmentWebRootPath, 
            string environmentName, string userId)
        {
            Lesson lesson = mapper.Map<LessonInputModel, Lesson>(lessonInputModel);
            await CreateLessonBasedOnEnvironmentAsync(lessonInputModel, environmentWebRootPath, environmentName, userId, lesson);
            await context.Lessons.AddAsync(lesson);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonAsync(
            LessonEditModel lessonEditModel, dynamic environmentWebRootPath, 
            string environmentName, string userId)
        {
            Lesson lesson = await FindLessonAsync(lessonEditModel);
            UpdateEntityProperties(lessonEditModel, lesson);
            await UpdateVideoAndFilesBasedOnEnvironmentAsync(lessonEditModel, environmentWebRootPath, environmentName, lesson);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonAdministrationAsync(AdministrationLessonModel model)
        {
            Lesson entity = context.Lessons.FirstOrDefault(x => x.Id == model.LessonId);

            entity.Name = model.LessonName ?? entity.Name;
            entity.Description = model.Description ?? entity.Description;
            entity.CategoryId = model.CategoryId;
            entity.Grade = model.Grade;
            entity.DateCreated = model.DateCreated;
            entity.IsDeleted = model.IsDeleted;
            entity.IsApproved = model.IsApproved;

            await context.SaveChangesAsync();
        }

        private async Task UpdateVideoAndFilesBasedOnEnvironmentAsync(
            LessonEditModel lessonEditModel, dynamic environmentWebRootPath, 
            string environmentName, Lesson lesson)
        {
            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
            dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, Guid.NewGuid().ToString() + ".zip");

            bool isDevelopment = environmentName == "Development";
            if (isDevelopment)
            {
                await UpdateVideoInDevelopment(lessonEditModel, environmentWebRootPath, lesson);
                await UpdateFilesInDevelopment(lessonEditModel, lesson, uploadsMaterialsPath, tempDirectory, actualDirectoryPlusZipName);
            }
            else
            {
                RawUploadResult materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonEditModel);
                Material materialEntity = await AddMaterialToDatabaseCloudinaryAsync(materialUploadResult.SecureUrl.AbsoluteUri, Guid.NewGuid().ToString());
                Data.Models.Video videoEntity = await UploadVideoCloudinaryAsync(lessonEditModel);

                lesson.MaterialId = materialEntity.Id;
                lesson.VideoId = videoEntity.Id;
            }
        }

        private async Task CreateLessonBasedOnEnvironmentAsync(
            LessonInputModel lessonInputModel, dynamic environmentWebRootPath, 
            string environmentName, string userId, Lesson lesson)
        {
            Data.Models.Video videoEntity;
            Material materialEntity;

            bool isDevelopment = environmentName == "Development";
            if (isDevelopment)
            {
                string stringGuid = Guid.NewGuid().ToString();
                dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
                dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
                dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

                await UploadMaterialsAsync(lessonInputModel, uploadsMaterialsPath);
                CreateZipArchiveWithTempFiles(tempDirectory, actualDirectoryPlusZipName);
                DeleteUnusedFilesInTempFolder(tempDirectory);

                materialEntity = await AddMaterialToDatabaseAsync(actualDirectoryPlusZipName, stringGuid);
                videoEntity = await UploadVideoAsync(lessonInputModel, environmentWebRootPath);
            }
            else
            {
                var materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonInputModel);
                materialEntity = await AddMaterialToDatabaseCloudinaryAsync(materialUploadResult.SecureUrl.AbsoluteUri, Guid.NewGuid().ToString());
                videoEntity = await UploadVideoCloudinaryAsync(lessonInputModel);
            }

            lesson.ApplicationUserId = userId;
            lesson.VideoId = videoEntity.Id;
            lesson.MaterialId = materialEntity.Id;
            lesson.DateCreated = DateTime.UtcNow;
        }

        private async Task UpdateFilesInDevelopment(
            LessonEditModel lessonEditModel, Lesson entity,
            dynamic uploadsMaterialsPath, dynamic tempDirectory, dynamic actualDirectoryPlusZipName)
        {
            if (lessonEditModel.Files != null)
            {
                string stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(lessonEditModel, uploadsMaterialsPath);
                CreateZipArchiveWithTempFiles(tempDirectory, actualDirectoryPlusZipName);
                DeleteUnusedFilesInTempFolder(tempDirectory);
                Material materialEntity = await AddMaterialToDatabaseAsync(actualDirectoryPlusZipName, stringGuid);
                entity.MaterialId = materialEntity.Id;
                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateVideoInDevelopment(LessonEditModel lessonEditModel, dynamic environmentWebRootPath, Lesson entity)
        {
            if (lessonEditModel.Video != null)
            {
                Data.Models.Video videoEntity = await UploadVideoAsync(lessonEditModel, environmentWebRootPath);
                entity.VideoId = videoEntity.Id;
                await context.SaveChangesAsync();
            }
        }

        private async Task<Lesson> FindLessonAsync(LessonEditModel lessonEditModel)
        {
            return await context.Lessons
                .Include(x => x.Material)
                .Include(x => x.Video)
                .FirstOrDefaultAsync(x => x.Id == lessonEditModel.LessonId);
        }

        private static void UpdateEntityProperties(LessonEditModel lessonEditModel, Lesson entity)
        {
            entity.Name = lessonEditModel.LessonName ?? entity.Name;
            entity.Description = lessonEditModel.Description ?? entity.Description;
            entity.CategoryId = lessonEditModel.CategoryId;
            entity.Grade = lessonEditModel.Grade;
        }

        private static ZipArchive CreateZipArchiveWithTempFiles(dynamic tempDirectory, dynamic actualDirectoryPlusZipName)
        {
            ZipArchive archive = ZipFile.Open(actualDirectoryPlusZipName, ZipArchiveMode.Create);
            foreach (string file in Directory.GetFiles(tempDirectory))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }

            return archive;
        }

        private async Task<Data.Models.Video> UploadVideoCloudinaryAsync(ILessonModel lessonInputModel)
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

            VideoUploadParams uploadParams = GenerateVideoUploadParams(video, videoStream);
            VideoUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);

            Data.Models.Video videoEntity = new Data.Models.Video
            {
                Name = video.FileName,
                ContentType = video.ContentType,
                DateCreated = DateTime.UtcNow,
                Link = uploadResult.SecureUrl.AbsoluteUri
            };

            await context.Videos.AddAsync(videoEntity);
            await context.SaveChangesAsync();
            return videoEntity;
        }

        private static VideoUploadParams GenerateVideoUploadParams(IFormFile video, MemoryStream videoStream)
        {
            return new VideoUploadParams()
            {
                File = new FileDescription(@$"{video.FileName}", videoStream),
                PublicId = video.FileName,
                Folder = "welearn-asp-net-core-app/videos/",
                Overwrite = true,
                UniqueFilename = true,
            };
        }

        public async Task UploadMaterialsAsync(ILessonModel lessonInputModel, dynamic uploadsMaterials)
        {
            // check if the sum of files' sizes is above 0 mb and below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(x => x.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFilesExtensions.Any(extension => file.FileName.EndsWith(extension)));
            bool areFilesValid = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesValid)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            foreach (IFormFile formFile in lessonInputModel.Files)
            {
                string uniqueFileName = GetUniqueFileName(formFile.FileName);
                string filePath = Path.Combine(uploadsMaterials, "temp", uniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }
            }
        }

        public async Task<Data.Models.Video> UploadVideoAsync(ILessonModel lessonInputModel, dynamic environmentWebRootPath)
        {
            IFormFile video = lessonInputModel.Video;
            bool isVideoExtensionAllowed = AllowedVideoExtensions.Any(x => video.FileName.EndsWith(x));
            bool isVideoWithAcceptableSize = video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            bool isVideoAcceptable = video != null && isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            string uniqueFileNameVideo = GetUniqueFileName(video.FileName);
            dynamic uploadsVideos = Path.Combine(environmentWebRootPath, "uploads", "videos");
            dynamic filePath = Path.Combine(uploadsVideos, uniqueFileNameVideo);
            await video.CopyToAsync(new FileStream(filePath, FileMode.Create));

            Data.Models.Video videoEntity = CreateVideoEntity(video, uniqueFileNameVideo);

            await context.Videos.AddAsync(videoEntity);
            await context.SaveChangesAsync();
            return videoEntity;
        }

        private static Data.Models.Video CreateVideoEntity(IFormFile video, string uniqueFileNameVideo)
        {
            return new Data.Models.Video
            {
                Name = video.FileName,
                ContentType = video.ContentType,
                DateCreated = DateTime.UtcNow,
                Link = Path.Combine("\\uploads", "videos", uniqueFileNameVideo)
            };
        }

        private async Task<RawUploadResult> UploadMaterialsCloudinaryAsync(ILessonModel lessonInputModel)
        {
            Cloudinary cloudinary = new Cloudinary();

            // check if the sum of files' sizes is above 0 mb, below 10 mb and all the extensions are permitted
            bool isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(file => file.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            bool isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFilesExtensions.Any(extension => file.FileName.EndsWith(extension)));
            bool areFilesAcceptable = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesAcceptable)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            Stream files = await archiveService.ArchiveFilesAsync(lessonInputModel.Files);
            string name = Guid.NewGuid().ToString();

            RawUploadParams uploadParams = GenerateRawUploadParam(files, name);
            RawUploadResult uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult;
        }

        private static RawUploadParams GenerateRawUploadParam(Stream files, string name)
        {
            return new RawUploadParams()
            {
                File = new FileDescription(@$"{name}.zip", files),
                PublicId = name,
                Folder = "welearn-asp-net-core-app/zip-files/",
                Overwrite = true,
                UniqueFilename = false,
            };
        }

        private static void DeleteUnusedFilesInTempFolder(dynamic tempDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(tempDirectory);
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private async Task<Material> AddMaterialToDatabaseCloudinaryAsync(string secureUrlAbsoluteUri, string stringGuid)
        {
            Material materialEntity = new Material
            {
                Name = stringGuid,
                DateCreated = DateTime.UtcNow,
                Link = secureUrlAbsoluteUri
            };

            await context.Materials.AddAsync(materialEntity);
            await context.SaveChangesAsync();
            return materialEntity;
        }

        private async Task<Material> AddMaterialToDatabaseAsync(dynamic actualDirectoryPlusZipName, string stringGuid)
        {
            Material materialEntity = new Material
            {
                Name = stringGuid,
                DateCreated = DateTime.UtcNow,
                Link = actualDirectoryPlusZipName
            };

            await context.Materials.AddAsync(materialEntity);
            await context.SaveChangesAsync();
            return materialEntity;
        }

        private static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            string uniqueFileName = Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 5)
                      + Path.GetExtension(fileName);

            return uniqueFileName;
        }
    }
}
