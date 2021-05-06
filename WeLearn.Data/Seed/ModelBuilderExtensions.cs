using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using WeLearn.Data.Models;

namespace WeLearn.Data.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            const string UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6";
        
            var applicationUser = new ApplicationUser
            {
                Id = UserId,
                Email = "default@gmail.com",
                EmailConfirmed = false,
                NormalizedEmail = "default@gmail.com".ToUpper(),
                UserName = "Username",
                NormalizedUserName = "Username".ToUpper(),
            };

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "User_qwerty_1234%");
            modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);

            modelBuilder.Entity<Comment>().HasData
            (
                new Comment { Id = 1, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "I like it!", LessonId = 1 },
                new Comment { Id = 2, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "Good, but can be imroved.", LessonId = 2 },
                new Comment { Id = 3, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "This is very nice.", LessonId = 3 }
            );

            modelBuilder.Entity<Report>().HasData
            (
                new Report { Id = 1, DateCreated = DateTime.UtcNow, Subject = "The language used in title", Description = "Bad language in lesson's title.", LessonId = 5},
                new Report { Id = 2, DateCreated = DateTime.UtcNow, Subject = "Bad words in username", Description = "This username is unacceptable.", ApplicationUserId = UserId },
                new Report { Id = 3, DateCreated = DateTime.UtcNow, Subject = "Swearing in comment", Description = "Bad language in comment.", CommentId = 1}
            );

            modelBuilder.Entity<Category>().HasData
            (
                new Category { Id = 1,  DateCreated = DateTime.UtcNow, Name = "Bulgarian Language" },
                new Category { Id = 2,  DateCreated = DateTime.UtcNow, Name = "Mathematics" },
                new Category { Id = 3,  DateCreated = DateTime.UtcNow, Name = "Informatics" },
                new Category { Id = 4,  DateCreated = DateTime.UtcNow, Name = "IT" },
                new Category { Id = 5,  DateCreated = DateTime.UtcNow, Name = "Geography" },
                new Category { Id = 6,  DateCreated = DateTime.UtcNow, Name = "Physical Education and Sport" },
                new Category { Id = 7,  DateCreated = DateTime.UtcNow, Name = "Literature" },
                new Category { Id = 8,  DateCreated = DateTime.UtcNow, Name = "Civic Education" },
                new Category { Id = 9,  DateCreated = DateTime.UtcNow, Name = "English Language" },
                new Category { Id = 10, DateCreated = DateTime.UtcNow, Name = "Russian Language" },
                new Category { Id = 11, DateCreated = DateTime.UtcNow, Name = "History" },
                new Category { Id = 12, DateCreated = DateTime.UtcNow, Name = "Biology" },
                new Category { Id = 13, DateCreated = DateTime.UtcNow, Name = "Chemistry" },
                new Category { Id = 14, DateCreated = DateTime.UtcNow, Name = "Music" },
                new Category { Id = 15, DateCreated = DateTime.UtcNow, Name = "Art" },
                new Category { Id = 16, DateCreated = DateTime.UtcNow, Name = "Technologies and Entrepreneurship" },
                new Category { Id = 17, DateCreated = DateTime.UtcNow, Name = "Others" }
            );

            modelBuilder.Entity<Video>().HasData
            (
                new Video { Id = 1,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Teaching", Link = "/uploads/videos/modal-verbs.mp4" },
                new Video { Id = 2,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Teaching", Link = "/uploads/videos/man-teaching.mp4" },
                new Video { Id = 3,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Coding", Link = "/uploads/videos/coding.mp4" },
                new Video { Id = 4,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Office Suite", Link = "/uploads/videos/office-suite.mp4" },
                new Video { Id = 5,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Ukraine", Link = "/uploads/videos/eastern-europe.mp4" },
                new Video { Id = 6,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Football", Link = "/uploads/videos/football.mp4" },
                new Video { Id = 7,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Literature", Link = "/uploads/videos/literature.mp4" },
                new Video { Id = 8,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Human Rights", Link = "/uploads/videos/human-rights.mp4" },
                new Video { Id = 9,  DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Modal Verbs", Link = "/uploads/videos/modal-verbs.mp4" },
                new Video { Id = 10, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Russian Language", Link = "/uploads/videos/russian-language.mp4" },
                new Video { Id = 11, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "History", Link = "/uploads/videos/history.mp4" },
                new Video { Id = 12, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Biology", Link = "/uploads/videos/biology.mp4" },
                new Video { Id = 13, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Chemistry", Link = "/uploads/videos/chemistry.mp4" },
                new Video { Id = 14, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Music", Link = "/uploads/videos/music.mp4" },
                new Video { Id = 15, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Painting", Link = "/uploads/videos/painting.mp4" },
                new Video { Id = 16, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Entrepreneurship", Link = "/uploads/videos/entrepreneurship.mp4" }
            );

            modelBuilder.Entity<Lesson>().HasData
            (
                 new Lesson { Id = 1,  VideoId = 1,  MaterialId = 1,  ApplicationUserId = UserId, CategoryId = 1,  DateCreated = DateTime.UtcNow, Name = "Pronouns, types", Description = "A lecture about pronouns and when to use them." },
                 new Lesson { Id = 2,  VideoId = 2,  MaterialId = 2,  ApplicationUserId = UserId, CategoryId = 2,  DateCreated = DateTime.UtcNow, Name = "Prime numbers", Description = "A natural number greater than 1 that is not a product of two smaller natural numbers." },
                 new Lesson { Id = 3,  VideoId = 3,  MaterialId = 3,  ApplicationUserId = UserId, CategoryId = 3,  DateCreated = DateTime.UtcNow, Name = "Developing with C#", Description = "About the C# language and the .NET development Platform. First steps." },
                 new Lesson { Id = 4,  VideoId = 4,  MaterialId = 4,  ApplicationUserId = UserId, CategoryId = 4,  DateCreated = DateTime.UtcNow, Name = "Excel", Description = "Data analysis." },
                 new Lesson { Id = 5,  VideoId = 5,  MaterialId = 5,  ApplicationUserId = UserId, CategoryId = 5,  DateCreated = DateTime.UtcNow, Name = "Ukraine, Eastern Europe", Description = "Eastern European Countries. Their iconomic growth and political stances. Ukraine." },
                 new Lesson { Id = 6,  VideoId = 6,  MaterialId = 6,  ApplicationUserId = UserId, CategoryId = 6,  DateCreated = DateTime.UtcNow, Name = "Football", Description = "Kicking a ball on the field." },
                 new Lesson { Id = 7,  VideoId = 7,  MaterialId = 7,  ApplicationUserId = UserId, CategoryId = 7,  DateCreated = DateTime.UtcNow, Name = "William Shakespere's 106 sonnet", Description = "A peek into Shakespere's art." },
                 new Lesson { Id = 8,  VideoId = 8,  MaterialId = 8,  ApplicationUserId = UserId, CategoryId = 8,  DateCreated = DateTime.UtcNow, Name = "Human rights", Description = "A lecture about rights of the people." },
                 new Lesson { Id = 9,  VideoId = 9,  MaterialId = 9,  ApplicationUserId = UserId, CategoryId = 9,  DateCreated = DateTime.UtcNow, Name = "Modal verbs", Description = "We use modals to show if we believe something is certain, possible or impossible." },
                 new Lesson { Id = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = UserId, CategoryId = 10, DateCreated = DateTime.UtcNow, Name = "Verbs of motion", Description = "A lecture about the verbs of motion and when to use them." },
                 new Lesson { Id = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = UserId, CategoryId = 11, DateCreated = DateTime.UtcNow, Name = "Peek in the past", Description = "A brief peek into our ancestors' life." },
                 new Lesson { Id = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = UserId, CategoryId = 12, DateCreated = DateTime.UtcNow, Name = "Cells. Prokaryotic and Eukaryotic", Description = "A lesson about the different types of cells and their differences." },
                 new Lesson { Id = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = UserId, CategoryId = 13, DateCreated = DateTime.UtcNow, Name = "Acids, Bases and pH", Description = "A lesson about acids, they effects on the environtment and usage cases." },
                 new Lesson { Id = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = UserId, CategoryId = 14, DateCreated = DateTime.UtcNow, Name = "Popular music", Description = "Genres, instruments and notation." },
                 new Lesson { Id = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = UserId, CategoryId = 15, DateCreated = DateTime.UtcNow, Name = "Painting", Description = "Pigments, brushes, bases, matrices." },
                 new Lesson { Id = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = UserId, CategoryId = 16, DateCreated = DateTime.UtcNow, Name = "Entrepreneurship", Description = "Creating a new business, bearing most of the risks and enjoying most of the rewards." }
             );

            modelBuilder.Entity<Material>().HasData
            (
                // /uploads/materials/cat-seed-dfd1-4ed3-a862-684cd9a35995.zip
                new Material { Id = 1,  DateCreated = DateTime.UtcNow, Name = "Teaching",         Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 2,  DateCreated = DateTime.UtcNow, Name = "Teaching",         Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 3,  DateCreated = DateTime.UtcNow, Name = "Coding",           Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 4,  DateCreated = DateTime.UtcNow, Name = "Office Suite",     Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 5,  DateCreated = DateTime.UtcNow, Name = "Ukraine",          Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 6,  DateCreated = DateTime.UtcNow, Name = "Football",         Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 7,  DateCreated = DateTime.UtcNow, Name = "Literature",       Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 8,  DateCreated = DateTime.UtcNow, Name = "Human Rights",     Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 9,  DateCreated = DateTime.UtcNow, Name = "Modal Verbs",      Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 10, DateCreated = DateTime.UtcNow, Name = "Russian Language", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 11, DateCreated = DateTime.UtcNow, Name = "History",          Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 12, DateCreated = DateTime.UtcNow, Name = "Biology",          Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 13, DateCreated = DateTime.UtcNow, Name = "Chemistry",        Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 14, DateCreated = DateTime.UtcNow, Name = "Music",            Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 15, DateCreated = DateTime.UtcNow, Name = "Painting",         Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 16, DateCreated = DateTime.UtcNow, Name = "Entrepreneurship", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" }
            );
        }
    }
}
