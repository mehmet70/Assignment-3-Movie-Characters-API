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
        // TODO: Add automapper relationships
        // TODO: Foreign keys can be null
        // TODO: Navigation null on delete

        // TODO: Check Controllers
        // TODO: Add [NotNullAttribute], [MaxLength(-, ErrorMessage=...)]?

        // TODO: Add update characters in movie
        // TODO: Add update movies in franchise

        // TODO: Add get characters in movie
        // TODO: Add get movies in franchise

        // TODO: Redo the migrations

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
