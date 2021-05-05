using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeLearn.Data;
using WeLearn.Data.Models;
using WeLearn.Data.Models.Interfaces;
using WeLearn.Data.Repositories;
using WeLearn.Data.Repositories.Interfaces;
using WeLearn.Services;
using WeLearn.Services.Interfaces;

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

            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            })
            .AddRazorRuntimeCompilation();

            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionSQLServer")));

            //if (WebHostEnvironment.IsDevelopment())
            //{
            //    services.AddDbContext<ApplicationDbContext>(options =>
            //        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));

            //    services.AddDatabaseDeveloperPageExceptionFilter();
            //}
            //else
            //{
            //    // https://github.com/jincod/dotnetcore-buildpack/issues/33#issuecomment-409935057
            //    // Heroku provides PostgreSQL connection URL via env variable
            //    //parse database URL. Format is postgres://<username>:<password>@<host>:<port>/<dbname>
            //    var connectionUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

            //    // Parse connection URL to connection string for Npgsql
            //    connectionUrl = connectionUrl.Replace("postgres://", string.Empty);

            //    var pgUserPass = connectionUrl.Split("@")[0];
            //    var pgHostPortDb = connectionUrl.Split("@")[1];
            //    var pgHostPort = pgHostPortDb.Split("/")[0];

            //    var pgDb = pgHostPortDb.Split("/")[1];
            //    var pgUser = pgUserPass.Split(":")[0];
            //    var pgPass = pgUserPass.Split(":")[1];
            //    var pgHost = pgHostPort.Split(":")[0];
            //    var pgPort = pgHostPort.Split(":")[1];

            //    var connectionString = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb}";
            //    Debug.WriteLine("#=> " + connectionString);
            //    Console.WriteLine("#=> " + connectionString);
            //    services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
            //}

            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseNpgsql(Configuration.GetConnectionString("DefaultConnectionPostgreSQL")));

            Debug.WriteLine("#=> " + Configuration.GetConnectionString("DefaultConnectionPostgreSQL"));

            services.AddDatabaseDeveloperPageExceptionFilter();

            //services.AddDefaultIdentity<IdentityUser>(options =>
            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            services.AddDefaultIdentity<ApplicationUser>(options => 
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
            .AddRoles<ApplicationRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient<ILessonsRepository, LessonRepository>();
            services.AddTransient<IRepository<SoftDeleteable>, Repository<SoftDeleteable>>();

            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<ILessonsService, LesonsService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IFileDownloadService, FileDownloadService>();
            services.AddTransient<IViewComponentsService, ViewComponentsService>();

            services.AddHttpContextAccessor();
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env, 
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
                ApplicationDbInitializer.SeedData(userManager, roleManager);
                //new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Manage}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
