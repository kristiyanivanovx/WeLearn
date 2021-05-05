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
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Infrastructure;

using WeLearn.Services.Interfaces;
using WeLearn.Data.Repositories.Interfaces;
using WeLearn.Data.Models.Interfaces;

namespace WeLearn.Services
{
    public class LesonsService : ILessonsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IRepository<SoftDeleteable> repository;
        private const string InvalidFileSizeMessage = 
            "There was an error with the upload of one of the videos. " +
            "Contact us or check whether all of your file formats are supported and if their sizes are acceptable.";

        private const string InvalidVideoExtensionOrSizeMessage =
            "There was an error with the video upload. Contact us or check whether your video format is supported and the size is acceptable.";

        private static readonly HashSet<string> AllowedVideoExtensions = new HashSet<string> { "video/mp4", "video/webm", "video/ogg" };

        public LesonsService(ApplicationDbContext context, IMapper mapper, IRepository<SoftDeleteable> repository)
        {
            this.context = context;
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<int> GetAllLessonsCountAsync()
        {
            return await context.Lessons.CountAsync();
        }
        
        public async Task<IEnumerable<LessonViewModel>> GetAllRelevantLessonsToVMAsync(string categoryName)
        {
            var allLessonsByCategory = await context.Lessons
                .Where(x => x.Category.Name == categoryName && !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var lessonsMapped = mapper.Map<LessonViewModel[]>(allLessonsByCategory);
            return lessonsMapped;
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
        
        public async Task<IEnumerable<LessonViewModel>> GetAllLessonsToVMAsync()
        {
            var lessons = await context.Lessons
                .Where(x => !x.IsDeleted)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var lessonsViewModel = mapper.Map<LessonViewModel[]>(lessons);
            return lessonsViewModel;
        }

        public async Task<IEnumerable<LessonViewModel>> UploadedByMeToVMAsync(string userId)
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

        public async Task CreateLessonAsync(LessonInputModel lessonInputModel, dynamic environmentWebRootPath, string userId)
        {
            // by default id gets mistaken for being id of the lesson, not the category
            var categoryId = lessonInputModel.Id;
            lessonInputModel.Id = 0;

            var lesson = mapper.Map<LessonInputModel, Lesson>(lessonInputModel);

            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            await UploadMaterialsAsync(lessonInputModel, uploadsMaterialsPath);
            dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");

            var stringGuid = Guid.NewGuid().ToString();
            dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, stringGuid + ".zip");

            using ZipArchive newFile = ZipFile.Open(actualDirectoryPlusZipName, ZipArchiveMode.Create);
            foreach (string file in Directory.GetFiles(tempDirectory))
            {
                newFile.CreateEntryFromFile(file, Path.GetFileName(file));
            }

            DeleteUnusedFilesInTempFolder(tempDirectory);
            Material materialEntity = await AddMaterialToDatabase(actualDirectoryPlusZipName, stringGuid);
            Video videoEntity = await UploadVideoAsync(lessonInputModel, environmentWebRootPath);

            lesson.ApplicationUserId = userId;
            lesson.VideoId = videoEntity.Id;
            lesson.MaterialId = materialEntity.Id;
            lesson.DateCreated = DateTime.UtcNow;
            lesson.CategoryId = categoryId;

            await context.Lessons.AddAsync(lesson);
            await context.SaveChangesAsync();
        }

        public async Task EditLessonAsync(LessonEditModel lessonEditModel, dynamic environmentWebRootPath, string userId)
        {
            var entity = context.Lessons
                .Include(x => x.Material)
                .Include(x => x.Video)
                .FirstOrDefault(x => x.Id == lessonEditModel.LessonId);

            entity.Name = lessonEditModel.LessonName ?? entity.Name;
            entity.Description = lessonEditModel.Description ?? entity.Description;
            entity.CategoryId = lessonEditModel.CategoryId;
            entity.Grade = lessonEditModel.Grade;

            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
            dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, Guid.NewGuid().ToString() + ".zip");

            if (lessonEditModel.Video != null)
            {
                Video videoEntity = await UploadVideoAsync(lessonEditModel, environmentWebRootPath);
                entity.VideoId = videoEntity.Id;
                await context.SaveChangesAsync();
            }

            if (lessonEditModel.Files != null)
            {
                var stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(lessonEditModel, uploadsMaterialsPath);
                using ZipArchive newFile = ZipFile.Open(actualDirectoryPlusZipName, ZipArchiveMode.Create);

                foreach (string file in Directory.GetFiles(tempDirectory))
                {
                    newFile.CreateEntryFromFile(file, Path.GetFileName(file));
                }

                DeleteUnusedFilesInTempFolder(tempDirectory);
                Material materialEntity = await AddMaterialToDatabase(actualDirectoryPlusZipName, stringGuid);
                entity.MaterialId = materialEntity.Id;
                await context.SaveChangesAsync();
            }

            entity.DateCreated = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }

        public async Task UploadMaterialsAsync<T>(T lessonInputModel, dynamic uploadsMaterials) where T : ILessonModel
        {
            foreach (var formFile in lessonInputModel.Files)
            {
                var isFileSizeAcceptable = formFile.Length > SharedConstants.MinimumFileSizeInBytes && formFile.Length < SharedConstants.MaximumFileSizeInBytes;
                //var isFileFormatAcceptable = false;

                if (isFileSizeAcceptable)
                {
                    var uniqueFileName = GetUniqueFileName(formFile.FileName);
                    string filePath2 = Path.Combine(uploadsMaterials, "temp", uniqueFileName);
                    using FileStream fileStream = new FileStream(filePath2, FileMode.Create);
                    await formFile.CopyToAsync(fileStream);
                }
                else
                {
                    throw new InvalidOperationException(InvalidFileSizeMessage);
                }
            }
        }

        public async Task<Video> UploadVideoAsync<T>(T lessonInputModel, dynamic environmentWebRootPath) where T : ILessonModel
        {
            var video = lessonInputModel.Video;
            var isVideoFormatAllowed = AllowedVideoExtensions.Contains(video.ContentType);
            var isVideWithAcceptableSize = video.Length > SharedConstants.MinimumVideoSizeInBytes && video.Length < SharedConstants.MaximumVideoSizeInBytes;

            if (video != null && isVideoFormatAllowed && isVideWithAcceptableSize)
            {
                string uniqueFileNameVideo = GetUniqueFileName(video.FileName);
                var uploadsVideos = Path.Combine(environmentWebRootPath, "uploads", "videos");
                var filePath = Path.Combine(uploadsVideos, uniqueFileNameVideo);
                await video.CopyToAsync(new FileStream(filePath, FileMode.Create));

                var videoEntity = new Video
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

            throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
        }

        public async Task DeleteLessonAsync(Lesson lesson)
        {
            lesson.IsDeleted = true;
            lesson.DateDeleted = DateTime.UtcNow;
            await context.SaveChangesAsync();
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

        private async Task<Material> AddMaterialToDatabase(dynamic actualDirectoryPlusZipName, string stringGuid)
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
