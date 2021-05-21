﻿using AutoMapper;
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

        public async Task<IEnumerable<LessonViewModel>> GetAllLessonsByCategoryAsync(string categoryName, string searchString)
        {
            IQueryable<Lesson> lessonsByCategory = this.context.Lessons.Where(x => x.Category.Name == categoryName && !x.IsDeleted && x.IsApproved);

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

        public async Task<IEnumerable<LessonViewModel>> GetCreatedByMeAsync(string userId)
        {
            List<Lesson> lessonsByMe = await this.context.Lessons
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
            Lesson lesson = this.context.Lessons.FirstOrDefault(x => x.Id == lessonId);
            this.context.Lessons.Remove(lesson);
            await this.context.SaveChangesAsync();
        }

        [RequestSizeLimit(MaximumVideoSizeInBytes + MaximumZipFileSizeInBytes)]
        public async Task CreateLessonAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, bool isDevelopment, string userId)
        {
            Lesson lesson = this.mapper.Map<LessonInputModel, Lesson>(lessonInputModel);
            await CreateLessonBasedOnEnvironmentAsync(lessonInputModel, environmentWebRootPath, isDevelopment, userId, lesson);
            await this.context.Lessons.AddAsync(lesson);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLessonAsync(LessonEditModel lessonEditModel, string environmentWebRootPath, bool isDevelopment, string userId)
        {
            Lesson lesson = await FindLessonAsync(lessonEditModel);
            UpdateEntityProperties(lessonEditModel, lesson);
            await UpdateVideoAndFilesBasedOnEnvironmentAsync(lessonEditModel, environmentWebRootPath, isDevelopment, lesson);
            await this.context.SaveChangesAsync();
        }

        public async Task EditLessonAdministrationAsync(AdministrationLessonModel model)
        {
            Lesson entity = this.context.Lessons.FirstOrDefault(x => x.Id == model.LessonId);

            entity.Name = model.LessonName ?? entity.Name;
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
            string tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
            string actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

            if (isDevelopment)
            {
                await UpdateVideoInDevelopment(lessonEditModel, environmentWebRootPath, lesson);
                await UpdateFilesInDevelopment(lessonEditModel, lesson, uploadsMaterialsPath, tempDirectory, actualDirectoryPlusZipName);
            }
            else
            {
                RawUploadResult materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonEditModel);
                Material materialEntity = await AddMaterialToDatabaseAsync(materialUploadResult.SecureUrl.AbsoluteUri, Guid.NewGuid().ToString());
                Data.Models.Video videoEntity = await UploadVideoCloudinaryAsync(lessonEditModel);

                lesson.MaterialId = materialEntity.Id;
                lesson.VideoId = videoEntity.Id;
            }
        }

        private async Task CreateLessonBasedOnEnvironmentAsync(LessonInputModel lessonInputModel, string environmentWebRootPath, bool isDevelopment, string userId, Lesson lesson)
        {
            Data.Models.Video videoEntity;
            Material materialEntity;

            if (isDevelopment)
            {
                string stringGuid = Guid.NewGuid().ToString();
                string uploadsMaterialsPath = this.inputOutputService.GenerateItemPath(environmentWebRootPath, "uploads", "materials");
                string tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
                string actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

                await UploadMaterialsAsync(lessonInputModel, uploadsMaterialsPath);
                this.inputOutputService.CreateZipArchiveWithTempFiles(tempDirectory, actualDirectoryPlusZipName);
                this.inputOutputService.DeleteFilesInFolder(tempDirectory);

                materialEntity = await AddMaterialToDatabaseAsync(actualDirectoryPlusZipName, stringGuid);
                videoEntity = await UploadVideoAsync(lessonInputModel, environmentWebRootPath);
            }
            else
            {
                var materialUploadResult = await UploadMaterialsCloudinaryAsync(lessonInputModel);
                materialEntity = await AddMaterialToDatabaseAsync(materialUploadResult.SecureUrl.AbsoluteUri, Guid.NewGuid().ToString());
                videoEntity = await UploadVideoCloudinaryAsync(lessonInputModel);
            }

            lesson.ApplicationUserId = userId;
            lesson.VideoId = videoEntity.Id;
            lesson.MaterialId = materialEntity.Id;
            lesson.DateCreated = DateTime.UtcNow;
        }

        private async Task UpdateFilesInDevelopment(
            LessonEditModel lessonEditModel, Lesson entity, string uploadsMaterialsPath, string tempDirectory, string actualDirectoryPlusZipName)
        {
            if (lessonEditModel.Files != null)
            {
                string stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(lessonEditModel, uploadsMaterialsPath);
                this.inputOutputService.CreateZipArchiveWithTempFiles(tempDirectory, actualDirectoryPlusZipName);
                this.inputOutputService.DeleteFilesInFolder(tempDirectory);
                Material materialEntity = await AddMaterialToDatabaseAsync(actualDirectoryPlusZipName, stringGuid);
                entity.MaterialId = materialEntity.Id;
                await this.context.SaveChangesAsync();
            }
        }

        private async Task UpdateVideoInDevelopment(LessonEditModel lessonEditModel, string environmentWebRootPath, Lesson entity)
        {
            if (lessonEditModel.Video != null)
            {
                Data.Models.Video videoEntity = await UploadVideoAsync(lessonEditModel, environmentWebRootPath);
                entity.VideoId = videoEntity.Id;
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
            entity.Name = lessonEditModel.LessonName ?? entity.Name;
            entity.Description = lessonEditModel.Description ?? entity.Description;
            entity.CategoryId = lessonEditModel.CategoryId;
            entity.Grade = lessonEditModel.Grade;
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

            VideoUploadParams uploadParams = GenerateVideoUploadParams(videoStream, video);
            VideoUploadResult uploadResult = await cloudinary.UploadAsync(uploadParams);

            string path = uploadResult.SecureUrl.AbsoluteUri;
            Data.Models.Video videoEntity = CreateVideoEntity(video, path);

            await this.context.Videos.AddAsync(videoEntity);
            await this.context.SaveChangesAsync();
            return videoEntity;
        }

        public async Task UploadMaterialsAsync(ILessonModel lessonInputModel, string uploadsMaterials)
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
                string uniqueFileName = this.inputOutputService.GetUniqueFileName(formFile.FileName);
                string filePath = this.inputOutputService.GenerateItemPath(uploadsMaterials, "temp", uniqueFileName);

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(fileStream);
                }
            }
        }

        public async Task<Data.Models.Video> UploadVideoAsync(ILessonModel lessonInputModel, string environmentWebRootPath)
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
            await video.CopyToAsync(new FileStream(fullFilePath, FileMode.Create));

            Data.Models.Video videoEntity = CreateVideoEntity(video, videoPath);

            await this.context.Videos.AddAsync(videoEntity);
            await this.context.SaveChangesAsync();

            return videoEntity;
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

            string name = Guid.NewGuid().ToString();

            Stream files = await inputOutputService.ArchiveFilesAsync(lessonInputModel.Files);
            RawUploadParams uploadParams = GenerateRawUploadParam(files, name);
            RawUploadResult uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult;
        }
        private static Data.Models.Video CreateVideoEntity(IFormFile video, string path)
            => new Data.Models.Video
                {
                    Name = video.FileName,
                    ContentType = video.ContentType,
                    DateCreated = DateTime.UtcNow,
                    Link = path
                };

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

        private static Material CreateMaterial(string path, string stringGuid)
            => new Material
                {
                    Name = stringGuid,
                    DateCreated = DateTime.UtcNow,
                    Link = path
                };

        private async Task<Material> AddMaterialToDatabaseAsync(string path, string stringGuid)
        {
            Material materialEntity = CreateMaterial(path, stringGuid);
            await this.context.Materials.AddAsync(materialEntity);
            await this.context.SaveChangesAsync();
            return materialEntity;
        }
    }
}
