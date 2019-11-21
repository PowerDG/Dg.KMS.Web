using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Mammal;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Animal
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);



            var builder = new ContainerBuilder();//准备容器
            builder.RegisterType<Doge>();//注册对象
            var container = builder.Build();//创建容器完毕
            var dog = container.Resolve<Doge>();//通过IOC容器创建对象
            dog.SayHello();


            builder.RegisterInstance(new Doge());//实例注入

            //builder.RegisterInstance(Singleton.GetInstance()).ExternallyOwned();//将单例对象托管到IOC容器


            builder.Register(c => new Person() { Name = "张三", Age = 20 });//Lambda表达式创建
            Person p1 = container.Resolve<Person>();



            builder.Register(c => new Person() { Name = "张三", Age = 20 });//Lambda表达式创建
            Person p2 = container.Resolve<Person>();

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
