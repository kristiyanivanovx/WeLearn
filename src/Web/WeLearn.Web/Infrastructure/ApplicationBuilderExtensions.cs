using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WeLearn.Data;
using WeLearn.Data.Infrastructure;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Identity;
using WeLearn.Services.CronJobs;
using WeLearn.Web.ChatApp;

namespace WeLearn.Web.Infrastructure
{
    public static class ApplicationBuilderExtensions
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
            ApplicationDbContext context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder SeedData(
            this IApplicationBuilder app,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            ApplicationDbInitializer.SeedData(userManager, roleManager);
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

            recurringJobManager.AddOrUpdate<TrainRecommendationModelJob>(
                "TrainRecommendationModelJob",
                x => x.Work(webHostEnvironment.ContentRootPath),
                Cron.Daily);

            recurringJobManager.AddOrUpdate<GetLikesInformationJob>(
                "GetLikesInformationJob",
                x => x.Work(webHostEnvironment.ContentRootPath),
                Cron.Hourly);

            recurringJobManager.AddOrUpdate<GetPersonalRecommendationsJob>(
                "GetPersonalRecommendationsJob",
                x => x.WorkAsync(webHostEnvironment.ContentRootPath),
                Cron.Hourly);

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
