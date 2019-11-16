using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Integration.WebApi;
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
            //属性注入控制器 
            containerBuilder.RegisterType<AutoDIController>().PropertiesAutowired();

 

            //模块化注入
            containerBuilder.RegisterModule<DefaultModule>();
            //containerBuilder.RegisterTypes(Controllers.Select(ti => ti.AsType()).ToArray()).PropertiesAutowired();
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


        public static void SetAutofacContainer()
        {
        //https://blog.csdn.net/weixin_30614587/article/details/98129699
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterType<InMemoryCache>().As<ICache>().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(AutoDIController).Assembly)
                .Where(t => t.Name.EndsWith("Controller2") || t.Name.EndsWith("AppService"))
            //builder.RegisterAssemblyTypes(typeof(StuEducationRepo).Assembly)
            //    .Where(t => t.Name.EndsWith("Repo"))
            //    .AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof(StudentRegisterDmnService).Assembly)
            //    .Where(t => t.Name.EndsWith("DmnService"))
            //    .AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof(StuEducationAppService).Assembly)
            //    .Where(t => t.Name.EndsWith("AppService"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);
            IContainer container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);

            // Configure Web API with the dependency resolver.
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}
