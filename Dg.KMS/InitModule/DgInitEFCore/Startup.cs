using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DgInitEFCore.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DgInitEFCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        public IContainer ApplicationContainer { get; private set; }
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //————————————————
            //版权声明：本文为CSDN博主「黄黄同学爱学习」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
            //原文链接：https://blog.csdn.net/huanghuangtongxue/article/details/78914306
            services.AddMvc();//.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
             
            var builder = new ContainerBuilder();//实例化 AutoFac  容器            
            builder.Populate(services);
            builder.RegisterGeneric(typeof(EfRepositoryBase<>)).As(typeof(IRepository<>)).InstancePerDependency();//注册仓储泛型
            //builder.RegisterType(typeof(IShareYunSourseAppService)).As(typeof(ShareYunSourseAppService));//ShareYunSourseAppService 实现了IShareYunSourseAppService 
            builder.RegisterType(typeof(ShareYunSourseAppService)).As(typeof(IShareYunSourseAppService));//ShareYunSourseAppService 实现了IShareYunSourseAppService 

            ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer);//第三方IOC接管 core内置DI容器
         
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
