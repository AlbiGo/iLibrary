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
        static string _env;
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _env = config.GetSection("ENV").Value;
            Console.WriteLine("ENV :" + _env);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    Console.WriteLine(_env);
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile($"appsettings.json");
                    if (!string.IsNullOrEmpty(_env))
                        config.AddJsonFile($"appsettings.{_env}.json");
                    config.AddEnvironmentVariables();
                })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
