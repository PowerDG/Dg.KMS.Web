using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using KMS.Twelve.Controllers;
using KMS.Twelve.Test;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace KMS.Twelve
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //替换控制器所有者
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc();
            //services.AddDbContext<BloggingContext>();

            services.AddDirectoryBrowser();
            var containerBuilder = new ContainerBuilder();
            //模块化注入
            containerBuilder.RegisterModule<DefaultModule>();
            //属性注入控制器 
            containerBuilder.RegisterType<AutoDIController>().PropertiesAutowired();

            // containerBuilder.RegisterTypes(feature.Controllers.Select(ti => ti.AsType()).ToArray()).PropertiesAutowired();
            containerBuilder.Populate(services);

            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }


        #region Old【ConfigureServices】

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();

        //    //services.AddDbContext<BloggingContext>();
        //    //这里就是注入服务 
        //    services.AddTransient<ITestService, TestService>();
        //    services.AddScoped<ITestService2, TestService2>();
        //    services.AddSingleton<ITestService3, TestService3>();
        //    services.AddDirectoryBrowser();
        //}

        #endregion

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
