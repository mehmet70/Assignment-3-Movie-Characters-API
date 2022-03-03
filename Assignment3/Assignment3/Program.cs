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
        // TODO: Fix movie franchiseid
        // TODO: Foreign keys can be null
        // TODO: Navigation null on delete

        // TODO: Check Controllers
        // Make everything JSON
        // TODO: Add [FromBody], [NotNullAttribute], [MaxLength(-, ErrorMessage=...)]?

        // TODO: Add documentation (swaggerdoc)
        // TODO: Add can return...?

        // TODO: Add update characters in movie
        // TODO: Add update movies in franchise

        // TODO: Add get characters in movie
        // TODO: Add get movies in franchise

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
