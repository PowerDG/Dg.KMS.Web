using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EFGetStarted
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //  services.AddDbContext<BloggingContext>(options =>
            //  options.UseNpgsql(Configuration.GetConnectionString("BloggingDatabase")
            //     // options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")
            //     ,options => options.EnableRetryOnFailure()
            //     ///连接复原 https://docs.microsoft.com/zh-cn/ef/core/miscellaneous/connection-resiliency
            // ));

            // var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            // optionsBuilder.UseSqlite("Data Source=blog.db");
            // using (var context = new BloggingContext(optionsBuilder.Options))
            // {
            // // do stuff
            // }

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
