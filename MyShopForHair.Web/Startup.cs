using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Core.Services;
using MyShopForHair.Infrastructure.Data;
using MyShopForHair.Infrastructure.Data.Repositories;
using MyShopForHair.Infrastructure.FileSystem;
using MyShopForHair.Infrastructure.Security;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using MyShopForHair.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatalogDbContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("MyShopForHair")));
            services.AddControllersWithViews();
            
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddScoped<IBrandViewModelService, BrandViewModelService>();

            services.AddScoped<IBrandService, BrandService>();

            services.AddScoped<ICriteriaViewModelService, CriteriaViewModelService>();

            services.AddScoped <ICriteriaService, CriteriaService>();

            services.AddScoped<IGroupViewModelService, GroupViewModelService>();

            services.AddScoped<IGroupService, GroupService>();

            services.AddScoped<IPasswordHasher, PasswordHasher>();

            services.AddScoped<IUserService, UserService>();
            // ViewModelServices
            services.AddScoped<IUserViewModelService, UserViewModelService>();
            // MVC services
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Index");
                    options.AccessDeniedPath = new PathString("/Account/Index");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
