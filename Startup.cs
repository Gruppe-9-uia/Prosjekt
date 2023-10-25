﻿using Microsoft.AspNetCore.Builder;

namespace Prosjekt
{
    //Hentet fra https://github.com/RaniaEG/XSSDemo/blob/main/MvcAPP/Startup.cs
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
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
            app.UseHsts();



            //// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
