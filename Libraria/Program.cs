using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Libraria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, confing) =>
                {
                    Console.WriteLine(hostingContext.HostingEnvironment.EnvironmentName);
                    confing.SetBasePath(Directory.GetCurrentDirectory());
                    confing.AddJsonFile($"appsettings.json", optional : true, reloadOnChange : true);
                    confing.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}json", optional: true, reloadOnChange: true);
                    confing.AddEnvironmentVariables();
                }).UseStartup<Startup>();
    }
}
