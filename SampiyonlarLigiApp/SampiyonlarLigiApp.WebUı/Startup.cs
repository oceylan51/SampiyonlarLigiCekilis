using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Bussines.Concrete;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Data.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.WebUı
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
            services.AddControllersWithViews();
            services.AddScoped<IGroup1Repository, EfCoreGroup1Repository>();
            services.AddScoped<IGroup2Repository, EfCoreGroup2Repository>();
            services.AddScoped<IGroup3Repository, EfCoreGroup3Repository>();
            services.AddScoped<IGroup4Repository, EfCoreGroup4Repository>();
            services.AddScoped<ILast32Group1Repository, EfCoreLast32Group1Repository>();
            services.AddScoped<ILast32Group2Repository, EfCoreLast32Group2Repository>();
            services.AddScoped<ILast32Group3Repository, EfCoreLast32Group3Repository>();
            services.AddScoped<ILast32Group4Repository, EfCoreLast32Group4Repository>();
            services.AddScoped<ILast32Group5Repository, EfCoreLast32Group5Repository>();
            services.AddScoped<ILast32Group6Repository, EfCoreLast32Group6Repository>();
            services.AddScoped<ILast32Group7Repository, EfCoreLast32Group7Repository>();
            services.AddScoped<ILast32Group8Repository, EfCoreLast32Group8Repository>();
            services.AddScoped<IFixtureRepository, EfCoreFixtureRepository>();
            services.AddScoped<ITeamsRepository, EfCoreTeamsRepository>();


            services.AddScoped<IGroup1Service, Group1Manager>();
            services.AddScoped<IGroup2Service, Group2Manager>();
            services.AddScoped<IGroup3Service, Group3Manager>();
            services.AddScoped<IGroup4Service, Group4Manager>();
            services.AddScoped<ILast32Group1Service, Last32Group1Manager>();
            services.AddScoped<ILast32Group2Service, Last32Group2Manager>();
            services.AddScoped<ILast32Group3Service, Last32Group3Manager>();
            services.AddScoped<ILast32Group4Service, Last32Group4Manager>();
            services.AddScoped<ILast32Group5Service, Last32Group5Manager>();
            services.AddScoped<ILast32Group6Service, Last32Group6Manager>();
            services.AddScoped<ILast32Group7Service, Last32Group7Manager>();
            services.AddScoped<ILast32Group8Service, Last32Group8Manager>();
            services.AddScoped<IFixtureService, FixtureManager>();
            services.AddScoped<ITeamsService, TeamsManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
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
