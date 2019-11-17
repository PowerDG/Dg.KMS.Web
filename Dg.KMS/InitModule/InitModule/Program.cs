using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace InitModule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseServiceProviderFactory(new AutofacServiceProviderFactory()) //Ôö¼Ó
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
