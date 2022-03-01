using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        // TODO: Seed movie data
        // TODO: Add movie controller
        // TODO: Add character Get
        // TODO: Add character GetById
        // TODO: Add character Post
        // TODO: Add character Put
        // TODO: Add character Delete

        // TODO: Add franchise class
        // TODO: Add migration
        // TODO: Check nullability, URL, required etc.
        // TODO: Seed franchise data
        // TODO: Add franchise controller
        // TODO: Add character Get
        // TODO: Add character GetById
        // TODO: Add character Post
        // TODO: Add character Put
        // TODO: Add character Delete

        // TODO: Add character movie relationship
        // TODO: Add update characters in movie
        // TODO: Add movie franchise relationship
        // TODO: Add update movies in franchise

        // TODO: Add DTOs

        // TODO: Repository pattern?

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
