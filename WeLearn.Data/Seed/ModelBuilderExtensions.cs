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
                Email = "user@gmail.com",
                EmailConfirmed = true,
                FirstName = "Firstname",
                LastName = "Lastname",
                UserName = "Username"
            };

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            applicationUser.PasswordHash = passwordHasher.HashPassword(applicationUser, "user_qwerty_1234?!Asd");

            modelBuilder.Entity<ApplicationUser>().HasData(applicationUser);

            modelBuilder.Entity<Comment>().HasData
            (
                new Comment { CommentId = 1, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "I like it!", PostId = 1 },
                new Comment { CommentId = 2, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "Good, but can be imroved.", PostId = 2 },
                new Comment { CommentId = 3, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "This is very nice.", PostId = 3 }
            );

            modelBuilder.Entity<Report>().HasData
            (
                new Report { ReportId = 1, DateCreated = DateTime.UtcNow, Subject = "The language used in title", Description = "Bad language in lesson's title.", PostId = 5},
                new Report { ReportId = 2, DateCreated = DateTime.UtcNow, Subject = "Bad words in username", Description = "This username is unacceptable.", ApplicationUserId = UserId },
                new Report { ReportId = 3, DateCreated = DateTime.UtcNow, Subject = "Swearing in comment", Description = "Bad language in comment.", CommentId = 1}
            );

            modelBuilder.Entity<Category>().HasData
            (
                new Category { CategoryId = 1,  DateCreated = DateTime.UtcNow, CategoryName = "Bulgarian Language" },
                new Category { CategoryId = 2,  DateCreated = DateTime.UtcNow, CategoryName = "Mathematics" },
                new Category { CategoryId = 3,  DateCreated = DateTime.UtcNow, CategoryName = "Informatics" },
                new Category { CategoryId = 4,  DateCreated = DateTime.UtcNow, CategoryName = "IT" },
                new Category { CategoryId = 5,  DateCreated = DateTime.UtcNow, CategoryName = "Geography" },
                new Category { CategoryId = 6,  DateCreated = DateTime.UtcNow, CategoryName = "Physical Education and Sport" },
                new Category { CategoryId = 7,  DateCreated = DateTime.UtcNow, CategoryName = "Literature" },
                new Category { CategoryId = 8,  DateCreated = DateTime.UtcNow, CategoryName = "Civic Education" },
                new Category { CategoryId = 9,  DateCreated = DateTime.UtcNow, CategoryName = "English Language" },
                new Category { CategoryId = 10, DateCreated = DateTime.UtcNow, CategoryName = "Russian Language" },
                new Category { CategoryId = 11, DateCreated = DateTime.UtcNow, CategoryName = "History" },
                new Category { CategoryId = 12, DateCreated = DateTime.UtcNow, CategoryName = "Biology" },
                new Category { CategoryId = 13, DateCreated = DateTime.UtcNow, CategoryName = "Chemistry" },
                new Category { CategoryId = 14, DateCreated = DateTime.UtcNow, CategoryName = "Music" },
                new Category { CategoryId = 15, DateCreated = DateTime.UtcNow, CategoryName = "Art" },
                new Category { CategoryId = 16, DateCreated = DateTime.UtcNow, CategoryName = "Technologies and Entrepreneurship" },
                new Category { CategoryId = 17, DateCreated = DateTime.UtcNow, CategoryName = "Others" }
            );

            modelBuilder.Entity<Video>().HasData
            (
                new Video { VideoId = 1,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Teaching", Link = "/uploads/videos/modal-verbs.mp4" },
                new Video { VideoId = 2,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Teaching", Link = "/uploads/videos/man-teaching.mp4" },
                new Video { VideoId = 3,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Coding", Link = "/uploads/videos/coding.mp4" },
                new Video { VideoId = 4,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Office Suite", Link = "/uploads/videos/office-suite.mp4" },
                new Video { VideoId = 5,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Ukraine", Link = "/uploads/videos/eastern-europe.mp4" },
                new Video { VideoId = 6,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Football", Link = "/uploads/videos/football.mp4" },
                new Video { VideoId = 7,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Literature", Link = "/uploads/videos/literature.mp4" },
                new Video { VideoId = 8,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Human Rights", Link = "/uploads/videos/human-rights.mp4" },
                new Video { VideoId = 9,  DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Modal Verbs", Link = "/uploads/videos/modal-verbs.mp4" },
                new Video { VideoId = 10, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Russian Language", Link = "/uploads/videos/russian-language.mp4" },
                new Video { VideoId = 11, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "History", Link = "/uploads/videos/history.mp4" },
                new Video { VideoId = 12, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Biology", Link = "/uploads/videos/biology.mp4" },
                new Video { VideoId = 13, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Chemistry", Link = "/uploads/videos/chemistry.mp4" },
                new Video { VideoId = 14, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Music", Link = "/uploads/videos/music.mp4" },
                new Video { VideoId = 15, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Painting", Link = "/uploads/videos/painting.mp4" },
                new Video { VideoId = 16, DateCreated = DateTime.UtcNow, VideoContentType = "video/mp4", VideoName = "Entrepreneurship", Link = "/uploads/videos/entrepreneurship.mp4" }
            );

            modelBuilder.Entity<Post>().HasData
            (
                 new Post { PostId = 1,  VideoId = 1,  MaterialId = 1,  ApplicationUserId = UserId, CategoryId = 1,  DateCreated = DateTime.UtcNow, PostName = "Pronouns, types", Description = "A lecture about pronouns and when to use them." },
                 new Post { PostId = 2,  VideoId = 2,  MaterialId = 2,  ApplicationUserId = UserId, CategoryId = 2,  DateCreated = DateTime.UtcNow, PostName = "Prime numbers", Description = "A natural number greater than 1 that is not a product of two smaller natural numbers." },
                 new Post { PostId = 3,  VideoId = 3,  MaterialId = 3,  ApplicationUserId = UserId, CategoryId = 3,  DateCreated = DateTime.UtcNow, PostName = "Developing with C#", Description = "About the C# language and the .NET development Platform. First steps." },
                 new Post { PostId = 4,  VideoId = 4,  MaterialId = 4,  ApplicationUserId = UserId, CategoryId = 4,  DateCreated = DateTime.UtcNow, PostName = "Excel", Description = "Data analysis." },
                 new Post { PostId = 5,  VideoId = 5,  MaterialId = 5,  ApplicationUserId = UserId, CategoryId = 5,  DateCreated = DateTime.UtcNow, PostName = "Ukraine, Eastern Europe", Description = "Eastern European Countries. Their iconomic growth and political stances. Ukraine." },
                 new Post { PostId = 6,  VideoId = 6,  MaterialId = 6,  ApplicationUserId = UserId, CategoryId = 6,  DateCreated = DateTime.UtcNow, PostName = "Football", Description = "Kicking a ball on the field." },
                 new Post { PostId = 7,  VideoId = 7,  MaterialId = 7,  ApplicationUserId = UserId, CategoryId = 7,  DateCreated = DateTime.UtcNow, PostName = "William Shakespere's 106 sonnet", Description = "A peek into Shakespere's art." },
                 new Post { PostId = 8,  VideoId = 8,  MaterialId = 8,  ApplicationUserId = UserId, CategoryId = 8,  DateCreated = DateTime.UtcNow, PostName = "Human rights", Description = "A lecture about rights of the people." },
                 new Post { PostId = 9,  VideoId = 9,  MaterialId = 9,  ApplicationUserId = UserId, CategoryId = 9,  DateCreated = DateTime.UtcNow, PostName = "Modal verbs", Description = "We use modals to show if we believe something is certain, possible or impossible." },
                 new Post { PostId = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = UserId, CategoryId = 10, DateCreated = DateTime.UtcNow, PostName = "Verbs of motion", Description = "A lecture about the verbs of motion and when to use them." },
                 new Post { PostId = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = UserId, CategoryId = 11, DateCreated = DateTime.UtcNow, PostName = "Peek in the past", Description = "A brief peek into our ancestors' life." },
                 new Post { PostId = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = UserId, CategoryId = 12, DateCreated = DateTime.UtcNow, PostName = "Cells. Prokaryotic and Eukaryotic", Description = "A lesson about the different types of cells and their differences." },
                 new Post { PostId = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = UserId, CategoryId = 13, DateCreated = DateTime.UtcNow, PostName = "Acids, Bases and pH", Description = "A lesson about acids, they effects on the environtment and usage cases." },
                 new Post { PostId = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = UserId, CategoryId = 14, DateCreated = DateTime.UtcNow, PostName = "Popular music", Description = "Genres, instruments and notation." },
                 new Post { PostId = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = UserId, CategoryId = 15, DateCreated = DateTime.UtcNow, PostName = "Painting", Description = "Pigments, brushes, bases, matrices." },
                 new Post { PostId = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = UserId, CategoryId = 16, DateCreated = DateTime.UtcNow, PostName = "Entrepreneurship", Description = "Creating a new business, bearing most of the risks and enjoying most of the rewards." }
             );

            modelBuilder.Entity<Material>().HasData
            (
                // /uploads/materials/c5da89b9-1b3d-40e1-8787-45d3bbaeb380.zip
                new Material { MaterialId = 1,  DateCreated = DateTime.UtcNow, MaterialName = "Teaching",     Link = "..." },
                new Material { MaterialId = 2,  DateCreated = DateTime.UtcNow, MaterialName = "Teaching",     Link = "..." },
                new Material { MaterialId = 3,  DateCreated = DateTime.UtcNow, MaterialName = "Coding",       Link = "..." },
                new Material { MaterialId = 4,  DateCreated = DateTime.UtcNow, MaterialName = "Office Suite", Link = "..." },
                new Material { MaterialId = 5,  DateCreated = DateTime.UtcNow, MaterialName = "Ukraine",      Link = "..." },
                new Material { MaterialId = 6,  DateCreated = DateTime.UtcNow, MaterialName = "Football",     Link = "..." },
                new Material { MaterialId = 7,  DateCreated = DateTime.UtcNow, MaterialName = "Literature",   Link = "..." },
                new Material { MaterialId = 8,  DateCreated = DateTime.UtcNow, MaterialName = "Human Rights", Link = "..." },
                new Material { MaterialId = 9,  DateCreated = DateTime.UtcNow, MaterialName = "Modal Verbs",  Link = "..." },
                new Material { MaterialId = 10, DateCreated = DateTime.UtcNow, MaterialName = "Russian Language", Link = "..." },
                new Material { MaterialId = 11, DateCreated = DateTime.UtcNow, MaterialName = "History",      Link = "..." },
                new Material { MaterialId = 12, DateCreated = DateTime.UtcNow, MaterialName = "Biology",      Link = "..." },
                new Material { MaterialId = 13, DateCreated = DateTime.UtcNow, MaterialName = "Chemistry",    Link = "..." },
                new Material { MaterialId = 14, DateCreated = DateTime.UtcNow, MaterialName = "Music",        Link = "..." },
                new Material { MaterialId = 15, DateCreated = DateTime.UtcNow, MaterialName = "Painting",     Link = "..." },
                new Material { MaterialId = 16, DateCreated = DateTime.UtcNow, MaterialName = "Entrepreneurship", Link = "..." }
            );
        }
    }
}
