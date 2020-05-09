using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StreetPizza.Data;
using StreetPizza.Data.Concrete;
using StreetPizza.Data.Interfaces;

namespace StreetPizza
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //додаємо сервіси EntityFramework
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EFDbContext>(options => options.UseSqlServer(connection));
            //додаємо сервіси Identity
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<EFDbContext>();

            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            //підключення сервісів Identity
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: null,
                      template: "Menu/{category}/Page{productPage:int}",
                      defaults: new { Controller = "Menu", action = "Index" });

                routes.MapRoute(
                      name: null,
                      template: "Menu/Page{productPage:int}",
                      defaults: new
                      {
                          Controller = "Menu",
                          action = "Index",
                          productPage = 1
                      });

                routes.MapRoute(
                      name: null,
                      template: "Menu/{category}",
                      defaults: new
                      {
                          Controller = "Menu",
                          action = "Index",
                          productPage = 1
                      });

                routes.MapRoute(
                      name: null,
                      template: "Menu/",
                      defaults: new
                      {
                          Controller = "Menu",
                          action = "Index",
                          productPage = 1
                      });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                EFDbContext context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                Seeder.SeedData(context);
            }
        }
    }
}
