using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionSQLServer")));

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

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            })
            .AddRazorRuntimeCompilation();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<ILessonsService, LessonsService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<IArchiveService, ArchiveService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IFileDownloadService, FileDownloadService>();
            services.AddTransient<IViewComponentsService, ViewComponentsService>();

            services.AddHttpContextAccessor();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints();
        }
    }
}
