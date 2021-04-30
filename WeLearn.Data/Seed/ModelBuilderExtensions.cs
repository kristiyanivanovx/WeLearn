using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Models;

namespace WeLearn.Data.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            const string UserId = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            
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
                new Comment { CommentId = 1, ApplicationUserId = UserId, Content = "I like it!", PostId = 1 },
                new Comment { CommentId = 2, ApplicationUserId = UserId, Content = "Good, but can be imroved.", PostId = 2 },
                new Comment { CommentId = 3, ApplicationUserId = UserId, Content = "This is very nice.", PostId = 3 }
            );

            modelBuilder.Entity<Report>().HasData
            (
                new Report { ReportId = 1, Subject = "The language used in title", Description = "Bad language in lesson's title.", PostId = 5},
                new Report { ReportId = 2, Subject = "Bad words in username", Description = "Tjhis username is unacceptable.", ApplicationUserId = UserId },
                new Report { ReportId = 3, Subject = "Swearing in comment", Description = "Bad language in comment.", CommentId = 1}
            );

            modelBuilder.Entity<Category>().HasData
            (
                new Category { CategoryId = 1, CategoryName = "Bulgarian Language" },
                new Category { CategoryId = 2, CategoryName = "Mathematics" },
                new Category { CategoryId = 3, CategoryName = "Informatics" },
                new Category { CategoryId = 4, CategoryName = "IT" },
                new Category { CategoryId = 5, CategoryName = "Geography" },
                new Category { CategoryId = 6, CategoryName = "Physical Education and Sport" },
                new Category { CategoryId = 7, CategoryName = "Literature" },
                new Category { CategoryId = 8, CategoryName = "Civic Education" },
                new Category { CategoryId = 9, CategoryName = "English Language" },
                new Category { CategoryId = 10, CategoryName = "Russian Language" },
                new Category { CategoryId = 11, CategoryName = "History" },
                new Category { CategoryId = 12, CategoryName = "Biology" },
                new Category { CategoryId = 13, CategoryName = "Chemistry" },
                new Category { CategoryId = 14, CategoryName = "Music" },
                new Category { CategoryId = 15, CategoryName = "Art" },
                new Category { CategoryId = 16, CategoryName = "Technologies and Entrepreneurship" }
            );

            modelBuilder.Entity<Video>().HasData
            (
                new Video { VideoId = 1,  /*PostId = 1, */ VideoName = "Whitey", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 2,  /*PostId = 2, */ VideoName = "Rocks", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 3,  /*PostId = 3, */ VideoName = "Fancy Setup", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 4,  /*PostId = 4, */ VideoName = "Greeny", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 5,  /*PostId = 5, */ VideoName = "Textile", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 6,  /*PostId = 6, */ VideoName = "Concrete Building", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 7,  /*PostId = 7, */ VideoName = "Moss", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 8,  /*PostId = 8, */ VideoName = "Fire", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 9,  /*PostId = 9, */ VideoName = "Lemons", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 10, /*PostId = 10,*/ VideoName = "Coffee", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 11, /*PostId = 11,*/ VideoName = "Flags", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 12, /*PostId = 12,*/ VideoName = "House", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 13, /*PostId = 13,*/ VideoName = "Snail", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 14, /*PostId = 14,*/ VideoName = "Jars", Link = "/uploads/videos/sample2.mp4" },
                new Video { VideoId = 15, /*PostId = 15,*/ VideoName = "Nightcity", Link = "/uploads/videos/sample.mp4" },
                new Video { VideoId = 16, /*PostId = 16,*/ VideoName = "Statue", Link = "/uploads/videos/sample2.mp4" }
            );

            modelBuilder.Entity<Post>().HasData
            (
                 new Post { PostId = 1,  VideoId = 1,  MaterialId = 1,  ApplicationUserId = UserId, CategoryId = 1, PostName = "Pronouns, types", Description = "A lecture about pronouns and when to use them." },
                 new Post { PostId = 2,  VideoId = 2,  MaterialId = 2,  ApplicationUserId = UserId, CategoryId = 2, PostName = "Prime numbers", Description = "A natural number greater than 1 that is not a product of two smaller natural numbers." },
                 new Post { PostId = 3,  VideoId = 3,  MaterialId = 3,  ApplicationUserId = UserId, CategoryId = 3, PostName = "Developing with C#", Description = "About the C# language and the .NET development Platform. First steps/" },
                 new Post { PostId = 4,  VideoId = 4,  MaterialId = 4,  ApplicationUserId = UserId, CategoryId = 4, PostName = "Excel", Description = "Data analysis." },
                 new Post { PostId = 5,  VideoId = 5,  MaterialId = 5,  ApplicationUserId = UserId, CategoryId = 5, PostName = "Bulgaria, Eastern Europe", Description = "Eastern European Countries. Their iconomic growth and political stances. Bulgaria." },
                 new Post { PostId = 6,  VideoId = 6,  MaterialId = 6,  ApplicationUserId = UserId, CategoryId = 6, PostName = "Football", Description = "Kicking a ball on the field." },
                 new Post { PostId = 7,  VideoId = 7,  MaterialId = 7,  ApplicationUserId = UserId, CategoryId = 7, PostName = "William Shakespere's 106 sonnet", Description = "A peek into Shakespere's art." },
                 new Post { PostId = 8,  VideoId = 8,  MaterialId = 8,  ApplicationUserId = UserId, CategoryId = 8, PostName = "Human rights", Description = "A lecture about rights of the people." },
                 new Post { PostId = 9,  VideoId = 9,  MaterialId = 9,  ApplicationUserId = UserId, CategoryId = 9, PostName = "Modal verbs", Description = "We use modals to show if we believe something is certain, possible or impossible." },
                 new Post { PostId = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = UserId, CategoryId = 10, PostName = "Verbs of motion", Description = "A lecture about the verbs of motion and when to use them." },
                 new Post { PostId = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = UserId, CategoryId = 11, PostName = "First Bulgarian Empire Part I", Description = "A lesson about the First Bulgarian Empire, founded 681 in Pliska." },
                 new Post { PostId = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = UserId, CategoryId = 12, PostName = "Cells. Prokaryotic and Eukaryotic", Description = "A lesson about the different types of cells and their differences." },
                 new Post { PostId = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = UserId, CategoryId = 13, PostName = "Acids, Bases and pH", Description = "A lesson about acids, they effects on the environtment and usage cases." },
                 new Post { PostId = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = UserId, CategoryId = 14, PostName = "Medieval music", Description = "Genres, instruments and notation." },
                 new Post { PostId = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = UserId, CategoryId = 15, PostName = "Painting", Description = "Pigments, brushes, bases, matrices." },
                 new Post { PostId = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = UserId, CategoryId = 16, PostName = "Entrepreneurship", Description = "Creating a new business, bearing most of the risks and enjoying most of the rewards." }
             );

            modelBuilder.Entity<Material>().HasData
            (
                new Material { MaterialId = 1,  /*PostId = 1, */ MaterialName = "Whitey", Link = "https://images.unsplash.com/photo-1598350740930-8dc9c2e1774a?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 2,  /*PostId = 2, */ MaterialName = "Rocks", Link = "https://images.unsplash.com/photo-1598125445316-6aab4ec2b38c?ixid=MXwxMjA3fDB8MHxzZWFyY2h8MTA5fHxzYW1wbGV8ZW58MHx8MHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" },
                new Material { MaterialId = 3,  /*PostId = 3, */ MaterialName = "Fancy Setup", Link = "https://images.unsplash.com/photo-1615220368123-9bb8faf4221b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1302&q=80" },
                new Material { MaterialId = 4,  /*PostId = 4, */ MaterialName = "Greeny", Link = "https://images.unsplash.com/photo-1532365673558-f9bb768644e7?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 5,  /*PostId = 5, */ MaterialName = "Textile", Link = "https://images.unsplash.com/photo-1598125445561-f1ab380e2cc3?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 6,  /*PostId = 6, */ MaterialName = "Concrete Building", Link = "https://images.unsplash.com/photo-1598350742412-8fe67cd5375b?ixlib=rb-1.2.1&ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 7,  /*PostId = 7, */ MaterialName = "Moss", Link = "https://images.unsplash.com/photo-1598125442810-7d196739bb5b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 8,  /*PostId = 8, */ MaterialName = "Fire", Link = "https://images.unsplash.com/photo-1529321044792-949d1f03e61e?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80" },
                new Material { MaterialId = 9,  /*PostId = 9, */ MaterialName = "Lemons", Link = "https://images.unsplash.com/photo-1600716051809-e997e11a5d52?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1333&q=80" },
                new Material { MaterialId = 10, /*PostId = 10,*/ MaterialName = "Coffee", Link = "https://images.unsplash.com/photo-1561336313-0bd5e0b27ec8?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 11, /*PostId = 11,*/ MaterialName = "Flags", Link = "https://images.unsplash.com/photo-1525534240745-6b6f65e8a25f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1490&q=80" },
                new Material { MaterialId = 12, /*PostId = 12,*/ MaterialName = "House", Link = "https://images.unsplash.com/photo-1562589539-346d763b0513?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=676&q=80" },
                new Material { MaterialId = 13, /*PostId = 13,*/ MaterialName = "Snail", Link = "https://images.unsplash.com/photo-1598125444907-f01590d16db5?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 14, /*PostId = 14,*/ MaterialName = "Jars", Link = "https://images.unsplash.com/photo-1567796422106-8f577f1b715b?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=675&q=80" },
                new Material { MaterialId = 15, /*PostId = 15,*/ MaterialName = "Nightcity", Link = "https://images.unsplash.com/photo-1524419986249-348e8fa6ad4a?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" },
                new Material { MaterialId = 16, /*PostId = 16,*/ MaterialName = "Statue", Link = "https://images.unsplash.com/photo-1558387886-d6988f49a2e0?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80" }
            );
        }
    }
}
