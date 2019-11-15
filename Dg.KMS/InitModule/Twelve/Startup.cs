using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Twelve
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ILifetimeScope ApplicationContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddApplicationInsightsTelemetry(Configuration);
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc();
            //services.AddDbContext<BloggingContext>();
            //这里就是注入服务
            services.AddTransient<ITestService, TestService>();
            services.AddDirectoryBrowser();
        }


        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    //services.AddApplicationInsightsTelemetry(Configuration);
        //    services.AddMvc();
        //    return RegisterAutofac(services);
        //}
        private IServiceProvider RegisterAutofac(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);
            var assembly = this.GetType().GetTypeInfo().Assembly;
            builder.RegisterType<AopInterceptor>();
            builder.RegisterAssemblyTypes(assembly)
            .Where(type =>
            typeof(IDependency).IsAssignableFrom(type) && !type.GetTypeInfo().IsAbstract)
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope().EnableInterfaceInterceptors().InterceptedBy(typeof(AopInterceptor));
            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
        }

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
