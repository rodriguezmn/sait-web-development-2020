
// Course       ----------------- CPRG 214 - .NET web applications
// Assignment 2 ----------------- MVC Core
// Author       ----------------- Marlon R.
// Date         ----------------- May 5, 2020


// Project      ----------------- Create an MVC Core solution for a company Asset Tracking System
//                                Three pages are required for the application, a Home page 
//                                where all assets are shown in a table with the possibility
//                                of filtering by asset type, an Add Asset page with a form to
//                                add new assets to a data base and a Create Asset Type page 
//                                where new asset types can be created.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TrackingSystem.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
