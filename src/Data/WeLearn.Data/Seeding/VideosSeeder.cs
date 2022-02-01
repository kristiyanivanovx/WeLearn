using System;
using System.Linq;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Data.Seeding
{
    public class VideosSeeder : ISeeder
    {
        public async Task SeedAsync(DatabaseContext databaseContext, IServiceProvider serviceProvider)
        {
            var videosCount = databaseContext.Videos.Count();
            if (videosCount == 0)
            {
                await databaseContext.Videos.AddRangeAsync(
                    new Video
                    {
                        Id = 1, LessonId = 1, ContentType = "video/mp4", Name = "Teaching",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622056204/welearn-asp-net-core-app/videos/seed/teacher-presenting.mp4"
                    },
                    new Video
                    {
                        Id = 2, LessonId = 2, ContentType = "video/mp4", Name = "Teaching",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053205/welearn-asp-net-core-app/videos/seed/man-teaching_miueor.mp4"
                    },
                    new Video
                    {
                        Id = 3, LessonId = 3, ContentType = "video/mp4", Name = "Coding",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053215/welearn-asp-net-core-app/videos/seed/coding_bbc9sv.mp4"
                    },
                    new Video
                    {
                        Id = 4, LessonId = 4, ContentType = "video/mp4",
                        Name = "Office Suite",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053172/welearn-asp-net-core-app/videos/seed/office-suite_lugjnz.mp4"
                    },
                    new Video
                    {
                        Id = 5, LessonId = 5, ContentType = "video/mp4", Name = "Ukraine",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053238/welearn-asp-net-core-app/videos/seed/eastern-europe_a7ljx0.mp4"
                    },
                    new Video
                    {
                        Id = 6, LessonId = 6, ContentType = "video/mp4", Name = "Football",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053255/welearn-asp-net-core-app/videos/seed/football_basmoc.mp4"
                    },
                    new Video
                    {
                        Id = 7, LessonId = 7, ContentType = "video/mp4", Name = "Literature",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053256/welearn-asp-net-core-app/videos/seed/literature_u1mriv.mp4"
                    },
                    new Video
                    {
                        Id = 8, LessonId = 8, ContentType = "video/mp4",
                        Name = "Human Rights",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053261/welearn-asp-net-core-app/videos/seed/human-rights_vbojip.mp4"
                    },
                    new Video
                    {
                        Id = 9, LessonId = 9, ContentType = "video/mp4",
                        Name = "Modal Verbs",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053183/welearn-asp-net-core-app/videos/seed/modal-verbs_jjnya3.mp4"
                    },
                    new Video
                    {
                        Id = 10, LessonId = 10, ContentType = "video/mp4",
                        Name = "Russian Language",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053192/welearn-asp-net-core-app/videos/seed/russian-language_uaydhx.mp4"
                    },
                    new Video
                    {
                        Id = 11, LessonId = 11, ContentType = "video/mp4", Name = "History",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053246/welearn-asp-net-core-app/videos/seed/history_sll9r9.mp4"
                    },
                    new Video
                    {
                        Id = 12, LessonId = 12, ContentType = "video/mp4", Name = "Biology",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053200/welearn-asp-net-core-app/videos/seed/biology_veyt5f.mp4"
                    },
                    new Video
                    {
                        Id = 13, LessonId = 13, ContentType = "video/mp4",
                        Name = "Chemistry",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053225/welearn-asp-net-core-app/videos/seed/chemistry_zpdwl9.mp4"
                    },
                    new Video
                    {
                        Id = 14, LessonId = 14, ContentType = "video/mp4", Name = "Music",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053175/welearn-asp-net-core-app/videos/seed/music_x6vt4y.mp4"
                    },
                    new Video
                    {
                        Id = 15, LessonId = 15, ContentType = "video/mp4", Name = "Painting",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053181/welearn-asp-net-core-app/videos/seed/painting_glxyu0.mp4"
                    },
                    new Video
                    {
                        Id = 16, LessonId = 16, ContentType = "video/mp4",
                        Name = "Entrepreneurship",
                        Link =
                            "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053249/welearn-asp-net-core-app/videos/seed/entrepreneurship_ulreso.mp4"
                    });
            }
        }
    }
}
