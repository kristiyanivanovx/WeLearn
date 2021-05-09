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

        public async Task DeleteLessonAsync(Lesson lesson)
        {
            lesson.IsDeleted = true;
            await context.SaveChangesAsync();
        }

        public async Task<T> GetLessonByIdAsync<T>(int id)
        {
            var lesson = await context.Lessons
                .Where(x => x.Id == id && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            var lessonMapped = mapper.Map<T>(lesson);
            return lessonMapped;
        }

        public async Task<IEnumerable<LessonViewModel>> GetAllRelevantLessonsAsync(string categoryName, string searchString)
        {
            var lessonsByCategory = context.Lessons.Where(x => x.Category.Name == categoryName && !x.IsDeleted);

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

            var lessonsMapped = mapper.Map<LessonViewModel[]>(lessonsByCategory);
            return lessonsMapped;
        }

        public async Task<IEnumerable<LessonViewModel>> GetAllLessonsAsync(string searchString)
        {
            var lessons = context.Lessons.Where(x => !x.IsDeleted);

            if (!string.IsNullOrEmpty(searchString))
            {
                lessons = lessons.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) || 
                                             x.Description.ToLower().Contains(searchString.ToLower()));
            }

            await lessons.Include(x => x.Category)
                    .Include(x => x.ApplicationUser)
                    .Include(x => x.Video)
                    .Include(x => x.Material)
                    .ToListAsync();

            var lessonsViewModel = mapper.Map<LessonViewModel[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<LessonViewModel>> UploadedByMeAsync(string userId)
        {
            var lessonsByMe = await context.Lessons
                .Where(x => x.ApplicationUserId == userId && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var lessonsByMeMapped = mapper.Map<LessonViewModel[]>(lessonsByMe);
            return lessonsByMeMapped;
        }

        [RequestSizeLimit(MaximumVideoSizeInBytes)]
        public async Task CreateLessonAsync(
            LessonInputModel lessonInputModel, 
            dynamic environmentWebRootPath, 
            string environmentName, 
            string userId)
        {
            // by default, id gets mapped to be the id of the lesson, not the category
            var categoryId = lessonInputModel.Id;
            lessonInputModel.Id = 0;

            var lesson = mapper.Map<LessonInputModel, Lesson>(lessonInputModel);
            await CreateLessonBasedOnEnvironmentAsync(lessonInputModel, environmentWebRootPath, environmentName, userId, categoryId, lesson);

            await context.Lessons.AddAsync(lesson);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonAsync(
            LessonEditModel lessonEditModel, 
            dynamic environmentWebRootPath, 
            string environmentName, 
            string userId)
        {
            Lesson lesson = await FindLessonAsync(lessonEditModel);
            UpdateEntityProperties(lessonEditModel, lesson);
            await UpdateVideoAndFilesBasedOnEnvironmentAsync(lessonEditModel, environmentWebRootPath, environmentName, lesson);
            await context.SaveChangesAsync();
        }

        private async Task UpdateVideoAndFilesBasedOnEnvironmentAsync(
            LessonEditModel lessonEditModel, 
            dynamic environmentWebRootPath, 
            string environmentName, 
            Lesson lesson)
        {
            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
            dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, Guid.NewGuid().ToString() + ".zip");

            var isDevelopment = environmentName == "Development";

            if (isDevelopment)
            {
                await UpdateVideoInDevelopment(lessonEditModel, environmentWebRootPath, lesson);
                await UpdateFilesInDevelopment(lessonEditModel, lesson, uploadsMaterialsPath, tempDirectory, actualDirectoryPlusZipName);
            }
            else
            {
                var materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonEditModel);
                var materialEntity = await AddMaterialToDatabaseCloudinaryAsync(materialUploadResult.SecureUrl.AbsoluteUri, Guid.NewGuid().ToString());
                var videoEntity = await UploadVideoCloudinaryAsync(lessonEditModel);

                lesson.MaterialId = materialEntity.Id;
                lesson.VideoId = videoEntity.Id;
            }
        }

        private async Task CreateLessonBasedOnEnvironmentAsync(
            LessonInputModel lessonInputModel,
            dynamic environmentWebRootPath, 
            string environmentName,
            string userId,
            int categoryId, 
            Lesson lesson)
        {
            Data.Models.Video videoEntity;
            Material materialEntity;

            var isDevelopment = environmentName == "Development";
            if (isDevelopment)
            {
                var stringGuid = Guid.NewGuid().ToString();
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
            lesson.CategoryId = categoryId;
        }

        private async Task UpdateFilesInDevelopment(
            LessonEditModel lessonEditModel, 
            Lesson entity,
            dynamic uploadsMaterialsPath,
            dynamic tempDirectory,
            dynamic actualDirectoryPlusZipName)
        {
            if (lessonEditModel.Files != null)
            {
                var stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(lessonEditModel, uploadsMaterialsPath);
                CreateZipArchiveWithTempFiles(tempDirectory, actualDirectoryPlusZipName);
                DeleteUnusedFilesInTempFolder(tempDirectory);
                Material materialEntity = await AddMaterialToDatabaseAsync(actualDirectoryPlusZipName, stringGuid);
                entity.MaterialId = materialEntity.Id;
                await context.SaveChangesAsync();
            }
        }

        private async Task UpdateVideoInDevelopment(
            LessonEditModel lessonEditModel, 
            dynamic environmentWebRootPath, 
            Lesson entity)
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
            var cloudinary = new Cloudinary();
            var video = lessonInputModel.Video;
            var isVideoExtensionAllowed = AllowedVideoExtensions.Any(x => video.FileName.EndsWith(x));
            var isVideoWithAcceptableSize = video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            var isVideoAcceptable = video != null && isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            using var videoStream = new MemoryStream();
            await video.OpenReadStream().CopyToAsync(videoStream);
            videoStream.Position = 0;

            var uploadParams = new VideoUploadParams()
            {
                File = new FileDescription(@$"{video.FileName}", videoStream),
                PublicId = video.FileName,
                Folder = "welearn-asp-net-core-app/videos/",
                Overwrite = true,
                UniqueFilename = true,
            };
            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            var videoEntity = new Data.Models.Video
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

        public async Task UploadMaterialsAsync<T>(T lessonInputModel, dynamic uploadsMaterials) where T : ILessonModel
        {
            // check if the sum of files' sizes is above 0 mb and below 10 mb amd all the extensions are permitted
            var isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(x => x.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            var isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFilesExtensions.Any(extension => file.FileName.EndsWith(extension)));
            var areFilesValid = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesValid)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            foreach (var formFile in lessonInputModel.Files)
            {
                var uniqueFileName = GetUniqueFileName(formFile.FileName);
                string filePath = Path.Combine(uploadsMaterials, "temp", uniqueFileName);
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }
            }
        }

        public async Task<Data.Models.Video> UploadVideoAsync<T>(T lessonInputModel, dynamic environmentWebRootPath) where T : ILessonModel
        {
            var video = lessonInputModel.Video;
            var isVideoExtensionAllowed = AllowedVideoExtensions.Any(x => video.FileName.EndsWith(x));
            var isVideoWithAcceptableSize = video.Length > MinimumVideoSizeInBytes && video.Length < MaximumVideoSizeInBytes;
            var isVideoAcceptable = video != null && isVideoExtensionAllowed && isVideoWithAcceptableSize;

            if (!isVideoAcceptable)
            {
                throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
            }

            string uniqueFileNameVideo = GetUniqueFileName(video.FileName);
            var uploadsVideos = Path.Combine(environmentWebRootPath, "uploads", "videos");
            var filePath = Path.Combine(uploadsVideos, uniqueFileNameVideo);
            await video.CopyToAsync(new FileStream(filePath, FileMode.Create));

            var videoEntity = new Data.Models.Video
            {
                Name = video.FileName,
                ContentType = video.ContentType,
                DateCreated = DateTime.UtcNow,
                Link = Path.Combine("\\uploads", "videos", uniqueFileNameVideo)
            };

            await context.Videos.AddAsync(videoEntity);
            await context.SaveChangesAsync();
            return videoEntity;
        }

        private async Task<RawUploadResult> UploadMaterialsCloudinaryAsync(ILessonModel lessonInputModel)
        {
            var cloudinary = new Cloudinary();

            // check if the sum of files' sizes is above 0 mb and below 10 mb and all the extensions are permitted
            var isFileSizeAcceptableForAll = lessonInputModel.Files.Sum(file => file.Length) > MinimumZipFileSizeInBytes && lessonInputModel.Files.Sum(x => x.Length) < MaximumZipFileSizeInBytes;
            var isFileExtensionAcceptableForAll = lessonInputModel.Files.All(file => AllowedFilesExtensions.Any(extension => file.FileName.EndsWith(extension)));
            var areFilesAcceptable = isFileSizeAcceptableForAll && isFileExtensionAcceptableForAll;

            if (!areFilesAcceptable)
            {
                throw new InvalidOperationException(InvalidFileSizeMessage);
            }

            Stream files = await archiveService.ArchiveFilesAsync(lessonInputModel.Files);
            var name = Guid.NewGuid().ToString();

            var uploadParams = new RawUploadParams()
            {
                File = new FileDescription(@$"{name}.zip", files),
                PublicId = name,
                Folder = "welearn-asp-net-core-app/zip-files/",
                Overwrite = true,
                UniqueFilename = false,
            };

            RawUploadResult uploadResult = cloudinary.Upload(uploadParams);
            return uploadResult;
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
