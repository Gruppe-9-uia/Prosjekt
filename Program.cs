
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Prosjekt.Entities;

public class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.WebHost.ConfigureKestrel(x => x.AddServerHeader = false);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        SetupDataConnections(builder);

        builder.Services.AddIdentity<EmployeeUser, EmployeeRole>()
            .AddEntityFrameworkStores<ProsjektContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

        SetupAuthentication(builder);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseStaticFiles();

        app.UseRouting();

        UseAuthentication(app);

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

        });
        app.MapControllers();
        app.MapRazorPages();

        app.Run();
    }

    private static void SetupDataConnections(WebApplicationBuilder builder)
    {

        builder.Services.AddDbContext<ProsjektContext>(options =>
        {
            options.UseMySql(builder.Configuration.GetConnectionString("MariaDb"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MariaDb")));
        });
        
    }

    private static void UseAuthentication(WebApplication app)
    {
        app.UseAuthentication();
        app.UseAuthorization();
    }

    private static void SetupAuthentication(WebApplicationBuilder builder)
    {
        //Setup for Authentication
        builder.Services.Configure<IdentityOptions>(options =>
        {
            // Default Lockout settings.
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedAccount = false;
            options.User.RequireUniqueEmail = true;
        });
        


    }


}