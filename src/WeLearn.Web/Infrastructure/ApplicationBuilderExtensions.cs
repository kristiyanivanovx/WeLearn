using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WeLearn.Data;
using WeLearn.Data.Infrastructure;
using WeLearn.Data.Models;
using WeLearn.Services.CronJobs;
using WeLearn.Web.ChatApp;

namespace WeLearn.Web.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
            => app.UseEndpoints(endpoints =>
                {
                    endpoints.MapHub<ChatHub>("/chatHub");
                    endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Manage}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapRazorPages();
                });

        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
            ApplicationDbContext context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder SeedData(this IApplicationBuilder app, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            ApplicationDbInitializer.SeedData(userManager, roleManager);
            return app;
        }

        public static IApplicationBuilder SeedHangfireJobs(this IApplicationBuilder app, IRecurringJobManager recurringJobManager, ApplicationDbContext applicationDbContext)
        {
            recurringJobManager.AddOrUpdate<DbCleanupJob>("DbCleanupJob", x => x.WorkAsync(), Cron.Weekly());
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
