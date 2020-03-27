using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicService.Assets;

//using Microsoft.Extensions.Hosting;
using MusicService.Assets.Interfaces;
using MusicService.Assets.Mocks;
using MusicService.Assets.Models;
using MusicService.Assets.Repository;

namespace MusicService
{
    public class Startup
    {
        private IConfigurationRoot _configuration;

        public Startup(IWebHostEnvironment hostingEnvironment)
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("dbSettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options
            .UseSqlServer(_configuration
            .GetConnectionString("DefaultConnection")));

            services.AddTransient<IInstances, MusicInstanceRepository>();
            services.AddTransient<IAlbums, AlbumRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "/",
                    pattern: "{controller=Default}/{action=Default}");

                endpoints.MapDefaultControllerRoute();
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent dbContent = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObjects.Initial(dbContent);
            }

        }
    }
}