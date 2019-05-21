﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Inspiratio.DotnetCore.Api
{
    public class Program
    {
        protected Program() { }

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}
