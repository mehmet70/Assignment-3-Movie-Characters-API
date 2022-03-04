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
        // TODO: Navigation null on delete
        // TODO: FirstOrDefault change back

        // TODO: Check Controllers
        // TODO: Add [NotNullAttribute], [MaxLength(-, ErrorMessage=...)]?
        // NotFound(); Message?

        // TODO: Summary methods, add returns

        // TODO: Database async await (only when accessing database)

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
