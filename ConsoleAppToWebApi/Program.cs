using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ConsoleAppToWebApi
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(WebHost =>
            {
                WebHost.UseStartup<StartUp>();
            });
        }
    }
}