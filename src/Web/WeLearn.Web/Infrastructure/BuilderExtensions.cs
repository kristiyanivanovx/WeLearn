﻿using Hangfire;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using WeLearn.Data;
using WeLearn.Data.Infrastructure;

using WeLearn.Data.Models.Identity;
using WeLearn.Services.CronJobs;
using WeLearn.Web.ChatApp;

namespace WeLearn.Web.Infrastructure
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
            => app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Manage}/{action=Index}/{id?}");
                // endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Manage}/{action=Index}/{id?}/{slug?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}/{slug?}");
                endpoints.MapRazorPages();
            });

        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
            DatabaseContext context = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();
            context.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder SeedData(
            this IApplicationBuilder app,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            DatabaseInitializer.SeedData(userManager, roleManager);
            return app;
        }

        public static IApplicationBuilder SeedHangfireJobs(
            this IApplicationBuilder app,
            IRecurringJobManager recurringJobManager,
            IWebHostEnvironment webHostEnvironment)
        {
            recurringJobManager.AddOrUpdate<DbCleanupJob>(
                "DbCleanupJob",
                x => x.WorkAsync(),
                Cron.Monthly());

            // Cron job every day - 24 hours
            recurringJobManager.AddOrUpdate<TrainRecommendationModelJob>(
                "TrainRecommendationModelJob",
                x => x.Work(webHostEnvironment.ContentRootPath),
                Cron.Daily);

            // Cron job every 12 hours
            recurringJobManager.AddOrUpdate<GetPersonalRecommendationsJob>(
                "GetPersonalRecommendationsJob",
                x => x.WorkAsync(webHostEnvironment.ContentRootPath),
                "0 */12 * * *");

            // Cron job every 11 hours
            recurringJobManager.AddOrUpdate<GetLikesInformationJob>(
                "GetLikesInformationJob",
                x => x.Work(webHostEnvironment.ContentRootPath),
                "0 */11 * * *");

            return app;
        }

        public static IApplicationBuilder UseHangfire(this IApplicationBuilder app)
        {
            app.UseHangfireServer(new BackgroundJobServerOptions { WorkerCount = 2 });
            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[] { new CustomDashboardAuthorizationFilter() }
            });

            return app;
        }
    }
}
