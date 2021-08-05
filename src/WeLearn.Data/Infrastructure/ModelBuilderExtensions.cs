using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeLearn.Data.Models;
using WeLearn.Data.Models.ChatApp;
using WeLearn.Data.Models.Enums;

namespace WeLearn.Data.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureRelations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
               .HasMany(x => x.SentPrivateMessages)
               .WithOne(x => x.Sender);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(x => x.ReceivedPrivateMessages)
               .WithOne(x => x.Receiver);

            modelBuilder.Entity<ChatApplicationUser>()
                .HasKey(x => new { x.ChatId, x.ApplicationUserId });

            // do not cascade delete the lessons on user delete, just set their owner to null
            modelBuilder.Entity<ApplicationUser>()
                 .HasMany(x => x.Lessons)
                 .WithOne(x => x.ApplicationUser)
                 .OnDelete(DeleteBehavior.SetNull);

            // do not cascade delete the reports on user delete, just set their owner to null
            modelBuilder.Entity<ApplicationUser>()
               .HasMany(x => x.Reports)
               .WithOne(x => x.ApplicationUser)
               .OnDelete(DeleteBehavior.SetNull);

            // cascade delete the comments on user delete
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.ApplicationUser)
                .OnDelete(DeleteBehavior.Cascade);

            // rules for deleting a report in administration
            modelBuilder.Entity<Report>()
                .HasOne(x => x.Lesson)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            // rules for deleting a report in administration
            modelBuilder.Entity<Report>()
                .HasOne(x => x.Comment)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Material>()
                .HasOne(x => x.Lesson)
                .WithOne(x => x.Material)
                .HasForeignKey<Material>(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Video>()
                .HasOne(x => x.Lesson)
                .WithOne(x => x.Video)
                .HasForeignKey<Video>(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Lesson>()
            //    .HasOne(x => x.Material)
            //    .WithOne(x => x.Lesson)
            //    .HasForeignKey<Lesson>(x => x.MaterialId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Lesson>()
            //    .HasOne(x => x.Video)
            //    .WithOne(x => x.Lesson)
            //    .HasForeignKey<Lesson>(x => x.VideoId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            const string UserId = "96f2bde2-eafb-4fe6-b5e9-fe36f009b8e6";

            ApplicationUser applicationUser = new ApplicationUser
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
                new Comment { Id = 2, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "The teacher is awesome.", LessonId = 2 },
                new Comment { Id = 3, DateCreated = DateTime.UtcNow, ApplicationUserId = UserId, Content = "This is just great.", LessonId = 3 }
            );

            modelBuilder.Entity<Report>().HasData
            (
                new Report { Id = 1, ApplicationUserId = UserId, DateCreated = DateTime.UtcNow, LessonId = 5, Subject = "The language used in title", Description = "Bad language in lesson's title." },
                new Report { Id = 3, ApplicationUserId = UserId, DateCreated = DateTime.UtcNow, CommentId = 1, Subject = "Unacceptable behaviour", Description = "Bad language in comment." }
            );

            modelBuilder.Entity<Category>().HasData
            (
                new Category { Id = 1, DateCreated = DateTime.UtcNow, Name = "Bulgarian Language" },
                new Category { Id = 2, DateCreated = DateTime.UtcNow, Name = "Mathematics" },
                new Category { Id = 3, DateCreated = DateTime.UtcNow, Name = "Informatics" },
                new Category { Id = 4, DateCreated = DateTime.UtcNow, Name = "IT" },
                new Category { Id = 5, DateCreated = DateTime.UtcNow, Name = "Geography" },
                new Category { Id = 6, DateCreated = DateTime.UtcNow, Name = "Physical Education and Sport" },
                new Category { Id = 7, DateCreated = DateTime.UtcNow, Name = "Literature" },
                new Category { Id = 8, DateCreated = DateTime.UtcNow, Name = "Civic Education" },
                new Category { Id = 9, DateCreated = DateTime.UtcNow, Name = "English Language" },
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
                new Video { Id = 1, LessonId = 1, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Teaching", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622056204/welearn-asp-net-core-app/videos/seed/teacher-presenting.mp4" },
                new Video { Id = 2, LessonId = 2, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Teaching", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053205/welearn-asp-net-core-app/videos/seed/man-teaching_miueor.mp4" },
                new Video { Id = 3, LessonId = 3, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Coding", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053215/welearn-asp-net-core-app/videos/seed/coding_bbc9sv.mp4" },
                new Video { Id = 4, LessonId = 4, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Office Suite", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053172/welearn-asp-net-core-app/videos/seed/office-suite_lugjnz.mp4" },
                new Video { Id = 5, LessonId = 5, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Ukraine", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053238/welearn-asp-net-core-app/videos/seed/eastern-europe_a7ljx0.mp4" },
                new Video { Id = 6, LessonId = 6, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Football", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053255/welearn-asp-net-core-app/videos/seed/football_basmoc.mp4" },
                new Video { Id = 7, LessonId = 7, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Literature", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053256/welearn-asp-net-core-app/videos/seed/literature_u1mriv.mp4" },
                new Video { Id = 8, LessonId = 8, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Human Rights", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053261/welearn-asp-net-core-app/videos/seed/human-rights_vbojip.mp4" },
                new Video { Id = 9, LessonId = 9, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Modal Verbs", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053183/welearn-asp-net-core-app/videos/seed/modal-verbs_jjnya3.mp4" },
                new Video { Id = 10, LessonId = 10, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Russian Language", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053192/welearn-asp-net-core-app/videos/seed/russian-language_uaydhx.mp4" },
                new Video { Id = 11, LessonId = 11, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "History", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053246/welearn-asp-net-core-app/videos/seed/history_sll9r9.mp4" },
                new Video { Id = 12, LessonId = 12, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Biology", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053200/welearn-asp-net-core-app/videos/seed/biology_veyt5f.mp4" },
                new Video { Id = 13, LessonId = 13, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Chemistry", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053225/welearn-asp-net-core-app/videos/seed/chemistry_zpdwl9.mp4" },
                new Video { Id = 14, LessonId = 14, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Music", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053175/welearn-asp-net-core-app/videos/seed/music_x6vt4y.mp4" },
                new Video { Id = 15, LessonId = 15, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Painting", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053181/welearn-asp-net-core-app/videos/seed/painting_glxyu0.mp4" },
                new Video { Id = 16, LessonId = 16, DateCreated = DateTime.UtcNow, ContentType = "video/mp4", Name = "Entrepreneurship", Link = "https://res.cloudinary.com/dgvfqp9zu/video/upload/v1622053249/welearn-asp-net-core-app/videos/seed/entrepreneurship_ulreso.mp4" }
            );

            modelBuilder.Entity<Lesson>().HasData
            (
                 new Lesson { Id = 1, VideoId = 1, MaterialId = 1, ApplicationUserId = UserId, IsApproved = true, CategoryId = 1, Grade = Grade.First, DateCreated = DateTime.UtcNow, Name = "Pronouns, types", Description = "A lecture about pronouns and when to use them." },
                 new Lesson { Id = 2, VideoId = 2, MaterialId = 2, ApplicationUserId = UserId, IsApproved = true, CategoryId = 2, Grade = Grade.Second, DateCreated = DateTime.UtcNow, Name = "Prime numbers", Description = "A natural number greater than 1 that is not a product of two smaller natural numbers." },
                 new Lesson { Id = 3, VideoId = 3, MaterialId = 3, ApplicationUserId = UserId, IsApproved = true, CategoryId = 3, Grade = Grade.Third, DateCreated = DateTime.UtcNow, Name = "Developing with C#", Description = "About the C# language and the .NET development Platform. First steps." },
                 new Lesson { Id = 4, VideoId = 4, MaterialId = 4, ApplicationUserId = UserId, IsApproved = true, CategoryId = 4, Grade = Grade.Fourth, DateCreated = DateTime.UtcNow, Name = "Excel", Description = "Data analysis." },
                 new Lesson { Id = 5, VideoId = 5, MaterialId = 5, ApplicationUserId = UserId, IsApproved = true, CategoryId = 5, Grade = Grade.Fifth, DateCreated = DateTime.UtcNow, Name = "Ukraine, Eastern Europe", Description = "Eastern European Countries. Their iconomic growth and political stances. Ukraine." },
                 new Lesson { Id = 6, VideoId = 6, MaterialId = 6, ApplicationUserId = UserId, IsApproved = true, CategoryId = 6, Grade = Grade.Sixth, DateCreated = DateTime.UtcNow, Name = "Football", Description = "Kicking a ball on the field." },
                 new Lesson { Id = 7, VideoId = 7, MaterialId = 7, ApplicationUserId = UserId, IsApproved = true, CategoryId = 7, Grade = Grade.Seventh, DateCreated = DateTime.UtcNow, Name = "William Shakespere's 106 sonnet", Description = "A peek into Shakespere's art." },
                 new Lesson { Id = 8, VideoId = 8, MaterialId = 8, ApplicationUserId = UserId, IsApproved = true, CategoryId = 8, Grade = Grade.Eighth, DateCreated = DateTime.UtcNow, Name = "Human rights", Description = "A lecture about rights of the people." },
                 new Lesson { Id = 9, VideoId = 9, MaterialId = 9, ApplicationUserId = UserId, IsApproved = true, CategoryId = 9, Grade = Grade.Ninth, DateCreated = DateTime.UtcNow, Name = "Modal verbs", Description = "We use modals to show if we believe something is certain, possible or impossible." },
                 new Lesson { Id = 10, VideoId = 10, MaterialId = 10, ApplicationUserId = UserId, IsApproved = true, CategoryId = 10, Grade = Grade.Tenth, DateCreated = DateTime.UtcNow, Name = "Verbs of motion", Description = "A lecture about the verbs of motion and when to use them." },
                 new Lesson { Id = 11, VideoId = 11, MaterialId = 11, ApplicationUserId = UserId, IsApproved = true, CategoryId = 11, Grade = Grade.Eleventh, DateCreated = DateTime.UtcNow, Name = "Peek in the past", Description = "A brief peek into our ancestors' life." },
                 new Lesson { Id = 12, VideoId = 12, MaterialId = 12, ApplicationUserId = UserId, IsApproved = true, CategoryId = 12, Grade = Grade.Twelfth, DateCreated = DateTime.UtcNow, Name = "Cells. Prokaryotic and Eukaryotic", Description = "A lesson about the different types of cells and their differences." },
                 new Lesson { Id = 13, VideoId = 13, MaterialId = 13, ApplicationUserId = UserId, IsApproved = true, CategoryId = 13, Grade = Grade.Mixed, DateCreated = DateTime.UtcNow, Name = "Acids, Bases and pH", Description = "A lesson about acids, they effects on the environtment and usage cases." },
                 new Lesson { Id = 14, VideoId = 14, MaterialId = 14, ApplicationUserId = UserId, IsApproved = true, CategoryId = 14, Grade = Grade.Fifth, DateCreated = DateTime.UtcNow, Name = "Popular music", Description = "Genres, instruments and notation." },
                 new Lesson { Id = 15, VideoId = 15, MaterialId = 15, ApplicationUserId = UserId, IsApproved = true, CategoryId = 15, Grade = Grade.First, DateCreated = DateTime.UtcNow, Name = "Painting", Description = "Pigments, brushes, bases, matrices." },
                 new Lesson { Id = 16, VideoId = 16, MaterialId = 16, ApplicationUserId = UserId, IsApproved = true, CategoryId = 16, Grade = Grade.Second, DateCreated = DateTime.UtcNow, Name = "Entrepreneurship", Description = "Creating a new business, bearing most of the risks and enjoying most of the rewards." }
             );

            modelBuilder.Entity<Material>().HasData
            (
                new Material { Id = 1, LessonId = 1, DateCreated = DateTime.UtcNow, Name = "Teaching", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 2, LessonId = 2, DateCreated = DateTime.UtcNow, Name = "Teaching", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 3, LessonId = 3, DateCreated = DateTime.UtcNow, Name = "Coding", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 4, LessonId = 4, DateCreated = DateTime.UtcNow, Name = "Office Suite", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 5, LessonId = 5, DateCreated = DateTime.UtcNow, Name = "Ukraine", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 6, LessonId = 6, DateCreated = DateTime.UtcNow, Name = "Football", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 7, LessonId = 7, DateCreated = DateTime.UtcNow, Name = "Literature", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 8, LessonId = 8, DateCreated = DateTime.UtcNow, Name = "Human Rights", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 9, LessonId = 9, DateCreated = DateTime.UtcNow, Name = "Modal Verbs", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 10, LessonId = 10, DateCreated = DateTime.UtcNow, Name = "Russian Language", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 11, LessonId = 11, DateCreated = DateTime.UtcNow, Name = "History", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 12, LessonId = 12, DateCreated = DateTime.UtcNow, Name = "Biology", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 13, LessonId = 13, DateCreated = DateTime.UtcNow, Name = "Chemistry", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 14, LessonId = 14, DateCreated = DateTime.UtcNow, Name = "Music", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 15, LessonId = 15, DateCreated = DateTime.UtcNow, Name = "Painting", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" },
                new Material { Id = 16, LessonId = 16, DateCreated = DateTime.UtcNow, Name = "Entrepreneurship", Link = "https://res.cloudinary.com/dgvfqp9zu/raw/upload/v1620309301/welearn-asp-net-core-app/zip-files/seed-dfd1-4ed3-a862-684cd9a35995_mdzu3z.zip" }
            );
        }
    }
}
