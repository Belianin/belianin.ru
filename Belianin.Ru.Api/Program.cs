using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Belianin.Ru.Api
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
                    webBuilder.UseStartup<Startup>()
                        .ConfigureKestrel(o =>
                        {
                            o.ConfigureHttpsDefaults(https =>
                            {
                            });
                        })
                        .UseUrls("https://locahost");
                });
    }
}
