using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Web.Infrastructure;
using Microsoft.AspNetCore.SignalR;
using Hangfire;
using Hangfire.PostgreSql;
using System.Diagnostics;

namespace WeLearn
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            WebHostEnvironment = env;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddSignalR();

            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));

            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
            .AddRoles<ApplicationRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            })
            .AddRazorRuntimeCompilation();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<IChatService, ChatService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ILessonsService, LessonsService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<IInputOutputService, InputOutputService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IFileDownloadService, FileDownloadService>();
            services.AddTransient<IViewComponentsService, ViewComponentsService>();

            services.AddHttpContextAccessor();

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    IConfigurationSection googleAuthenticationSection = Configuration.GetSection("Authentication:Google");
                    options.ClientId = googleAuthenticationSection["ClientId"];
                    options.ClientSecret = googleAuthenticationSection["ClientSecret"];
                });

            services.AddHangfire(config => 
                config.UsePostgreSqlStorage(Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));
        }

        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env,
            IRecurringJobManager recurringJobManager,
            ApplicationDbContext applicationDbContext,
            UserManager<ApplicationUser> userManager, 
            RoleManager<ApplicationRole> roleManager)
        {
            app.MigrateDatabase();
            app.SeedData(userManager, roleManager);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.SeedHangfireJobs(recurringJobManager, applicationDbContext);
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseHangfire();

            app.UseEndpoints();
        }
    }
}
