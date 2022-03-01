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
        // TODO: Add franchise controller
        // TODO: Add franchise Get
        // TODO: Add franchise GetById
        // TODO: Add franchise Post
        // TODO: Add franchise Put
        // TODO: Add franchise Delete

        // TODO: Add documentation
        // TODO: Add can return...?

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
