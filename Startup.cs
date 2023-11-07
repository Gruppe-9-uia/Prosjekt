using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Models;
using System.Configuration;

namespace Prosjekt
{
    //Hentet fra https://github.com/RaniaEG/XSSDemo/blob/main/MvcAPP/Startup.cs
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
            services.AddDbContext<ProsjektContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(11, 3, 0)))); // Adjust the version according to your MariaDB version

            services.AddControllersWithViews();
            services.AddTransient<ProsjektContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Security set up of HTTP headers

            app.Use(async (context, next) =>
            {

                context.Response.Headers.Add("X-Xss-Protection", "1");
                context.Response.Headers.Add("X-Frame-Options", "DENY");
                context.Response.Headers.Add("Referrer-Policy", "no-referrer");
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                context.Response.Headers.Add(
                    "Content-Security-Policy",
                    "default-src 'self'; " +
                    "img-src 'self'; " +
                    "font-src 'self'; " +
                    "style-src 'self'; " +
                    "script-src 'self'" +
                    "frame-src 'self';" +
                    "connect-src 'self';");
                await next();
            });

            // To enforce HTTPS connection

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
            //// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
