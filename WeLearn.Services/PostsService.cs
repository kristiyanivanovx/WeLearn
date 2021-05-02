using AutoMapper;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Context;
using WeLearn.Data.Models;
using WeLearn.Infrastructure.Interfaces;
using WeLearn.Infrastructure.ViewModels;
using WeLearn.Infrastructure;

using WeLearn.Services.Interfaces;

namespace WeLearn.Services
{
    public class PostsService : IPostsService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

       

        private const string InvalidFileSizeMessage = 
            "There was an error with the upload of one of the videos. Contact us or check whether all of your file formats are supported and if their sizes are acceptable.";

        private const string InvalidVideoExtensionOrSizeMessage =
            "There was an error with the video upload. Contact us or check whether your video format is supported and the size is acceptable.";

        private static readonly HashSet<string> AllowedVideoExtensions = new HashSet<string> { "video/mp4", "video/webm", "video/ogg" };

        public PostsService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> GetAllPostsCountAsync()
        {
            return await context.Posts.CountAsync();
        }

        public async Task<IEnumerable<T>> GetAllPostsByCategoryNameAsync<T>(string categoryName)
        {
            var allPostsByCategory = await context.Posts
                .Where(x => x.Category.CategoryName == categoryName)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var posts = mapper.Map<T[]>(allPostsByCategory);
            return posts;
        }

        //PostViewModel, PostInputModel
        public async Task<T> GetPostByIdAsync<T>(int id)
        {
            var post = await context.Posts
                .Where(x => x.PostId == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .FirstOrDefaultAsync();

            var postMapped = mapper.Map<T>(post);
            return postMapped;
        }
        
        //PostViewModel
        public async Task<IEnumerable<T>> GetAllPostsAsync<T>()
        {
            var posts = await context.Posts
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var postsViewModel = mapper.Map<T[]>(posts);
            return postsViewModel;
        }

        //PostViewModel
        public async Task<IEnumerable<T>> UploadedByMeAsync<T>(string userId)
        {
            var postsByMe = await context.Posts
                .Where(x => x.ApplicationUserId == userId)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .Include(x => x.Video)
                .Include(x => x.Material)
                .ToListAsync();

            var postsByMeMapped = mapper.Map<T[]>(postsByMe);
            return postsByMeMapped;
        }

        public async Task CreatePostAsync(PostInputModel postInputModel, dynamic environmentWebRootPath, string userId)
        {
            var post = mapper.Map<PostInputModel, Post>(postInputModel);

            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            await UploadMaterialsAsync(postInputModel, uploadsMaterialsPath);
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
            Video videoEntity = await UploadVideoAsync(postInputModel, environmentWebRootPath);

            post.ApplicationUserId = userId;
            post.VideoId = videoEntity.VideoId;
            post.MaterialId = materialEntity.MaterialId;
            post.DateCreated = DateTime.UtcNow;

            await context.Posts.AddAsync(post);
            await context.SaveChangesAsync();
        }

        public async Task EditPostAsync(PostEditModel postEditModel, dynamic environmentWebRootPath, string userId)
        {
            var entity = context.Posts
                .Include(x => x.Material)
                .Include(x => x.Video)
                .FirstOrDefault(x => x.PostId == postEditModel.PostId);

            entity.PostName = postEditModel.LessonName ?? entity.PostName;
            entity.Description = postEditModel.Description ?? entity.Description;
            entity.CategoryId = postEditModel.CategoryId;
            entity.Grade = postEditModel.Grade;

            dynamic uploadsMaterialsPath = Path.Combine(environmentWebRootPath, "uploads", "materials");
            dynamic tempDirectory = Path.Combine(uploadsMaterialsPath, "temp");
            dynamic actualDirectoryPlusZipName = Path.Combine(uploadsMaterialsPath, Guid.NewGuid().ToString() + ".zip");

            if (postEditModel.Video != null)
            {
                Video videoEntity = await UploadVideoAsync(postEditModel, environmentWebRootPath);
                entity.VideoId = videoEntity.VideoId;
                await context.SaveChangesAsync();
            }

            if (postEditModel.Files != null)
            {
                var stringGuid = Guid.NewGuid().ToString();
                await UploadMaterialsAsync(postEditModel, uploadsMaterialsPath);
                using ZipArchive newFile = ZipFile.Open(actualDirectoryPlusZipName, ZipArchiveMode.Create);

                foreach (string file in Directory.GetFiles(tempDirectory))
                {
                    newFile.CreateEntryFromFile(file, Path.GetFileName(file));
                }

                DeleteUnusedFilesInTempFolder(tempDirectory);
                Material materialEntity = await AddMaterialToDatabase(actualDirectoryPlusZipName, stringGuid);
                entity.MaterialId = materialEntity.MaterialId;
                await context.SaveChangesAsync();
            }

            entity.DateCreated = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }

        public async Task UploadMaterialsAsync<T>(T postInputModel, dynamic uploadsMaterials) where T : IPostModel
        {
            foreach (var formFile in postInputModel.Files)
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

        public async Task<Video> UploadVideoAsync<T>(T postInputModel, dynamic environmentWebRootPath) where T : IPostModel
        {
            var video = postInputModel.Video;
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
                    VideoName = video.FileName,
                    VideoContentType = video.ContentType,
                    DateCreated = DateTime.UtcNow,
                    Link = Path.Combine("\\uploads", "videos", uniqueFileNameVideo)
                };

                await context.Videos.AddAsync(videoEntity);
                await context.SaveChangesAsync();
                return videoEntity;
            }

            throw new InvalidOperationException(InvalidVideoExtensionOrSizeMessage);
        }

        public async Task DeletePostAsync(int id)
        {
            var post = await context.Posts.FirstOrDefaultAsync(x => x.PostId == id);
            post.IsDeleted = true;
            post.DateDeleted = DateTime.UtcNow;
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
                MaterialName = stringGuid,
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
