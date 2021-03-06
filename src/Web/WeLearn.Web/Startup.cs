using System.Reflection;

using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebEssentials.AspNetCore.Pwa;
using WeLearn.Data;
using WeLearn.Data.Common;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models.Identity;
using WeLearn.Data.Repositories;
using WeLearn.Services.Data;
using WeLearn.Services.Data.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Services.Messaging;
using WeLearn.Services.Messaging.Interfaces;
using WeLearn.Web.Infrastructure;
using WeLearn.Web.ViewModels;

namespace WeLearn.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.Configuration = configuration;
            this.WebHostEnvironment = env;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddProgressiveWebApp();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddHttpContextAccessor();

            services.AddSignalR();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(this.Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));

            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<DatabaseContext>();

            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews(options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                })
                .AddRazorRuntimeCompilation();

            services.AddAntiforgery(options => options.HeaderName = "X-CSRF-TOKEN");

            services.AddSingleton(this.Configuration);

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IDbQueryRunner, DbQueryRunner>();

            // Application services
            services.AddTransient<IQuizzesService, QuizzesService>();
            services.AddTransient<IAnswersService, AnswersService>();
            services.AddTransient<IQuestionsService, QuestionsService>();
            services.AddTransient<IExaminationsService, ExaminationsService>();
            services.AddTransient<IChoicesService, ChoicesService>();
            services.AddTransient<IRecommendationsService, RecommendationsService>();
            services.AddTransient<IOrganizationsService, OrganizationsService>();
            services.AddTransient<IInformationService, InformationService>();
            services.AddTransient<IChatService, ChatService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ILikesService, LikesService>();
            services.AddTransient<ILessonsService, LessonsService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IInputOutputService, InputOutputService>();
            services.AddTransient<IFileDownloadService, FileDownloadService>();
            services.AddTransient<IViewComponentsService, ViewComponentsService>();
            services.AddTransient<IEmailSender>(_ =>
                new SendGridEmailService(this.Configuration["SendGrid:ApiKey"]));

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    IConfigurationSection googleAuthenticationSection =
                        this.Configuration.GetSection("Authentication:Google");

                    options.ClientId = googleAuthenticationSection["ClientId"];
                    options.ClientSecret = googleAuthenticationSection["ClientSecret"];
                    options.CorrelationCookie.SameSite = SameSiteMode.Lax;
                });

            services.AddHangfire(config =>
                config.UsePostgreSqlStorage(
                    this.Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IRecurringJobManager recurringJobManager,
            DatabaseContext applicationDatabaseContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            app.MigrateDatabase();
            app.SeedData(userManager, roleManager);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();

                app.UseHttpsRedirection();
            }

            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedHangfireJobs(recurringJobManager, this.WebHostEnvironment);
            app.UseHangfire();

            app.UseEndpoints();
        }
    }
}
