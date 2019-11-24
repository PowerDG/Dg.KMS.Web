using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TypeDemo.Domain;
using TypeDemo.IocInfo;
using TypeDemo.Log;

namespace TypeDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void RegisterContainer(ContainerBuilder builder)
        {
            builder.RegisterType<LogInterceptor>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors();
            var IControllerType = typeof(ControllerBase);
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => IControllerType.IsAssignableFrom(t) && t != IControllerType)
                .PropertiesAutowired()
                .EnableClassInterceptors();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        //public void ConfigureServices(IServiceCollection services)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {

            //2.替换系统默认Controller创建器
            //注意：Replace代码放在AddMvc之前
            //Replace代码的意思：使用ServiceBasedControllerActivator替换DefaultControllerActivator
            //    （意味着框架现在会尝试从IServiceProvider中解析控制器实例，
            //也就是return new AutofacServiceProvider(Container);）
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            //RegisterAssemblyTypes();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            var builder = new ContainerBuilder();
            builder.Populate(services);
            //builder.RegisterAssemblyTypes(typeof(Startup).Assembly).AsImplementedInterfaces();

            builder.RegisterType<LogInterceptor>();
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //    .AsImplementedInterfaces()
            //    .EnableInterfaceInterceptors();


            //这种使用方式需要自己指定在哪个类上使用，还有一种全局拦截器

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(LogInterceptor));
            
                
            //builder.RegisterType<TestDemo>();
            //RegisterContainer(builder);
            var IControllerType = typeof(ControllerBase);
            //Assembly.GetExecutingAssembly()：当前方法所在程序集
            //https://www.cnblogs.com/luna-hehe/p/10142159.html
            //Assembly.GetCallingAssembly()：调用当前方法的方法 所在的程序集
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => IControllerType.IsAssignableFrom(t) && t != IControllerType)
                .PropertiesAutowired()
                .EnableClassInterceptors();

            builder.RegisterType(typeof(TestDemo)).AsSelf()
                .OnRegistered(e => Console.WriteLine("OnRegistered在注册的时候调用!"))
                  .OnPreparing(e => Console.WriteLine("OnPreparing在准备创建的时候调用!"))
                  .OnActivating(e => Console.WriteLine("OnActivating在创建之前调用!"))
                  .OnActivated(e => Console.WriteLine("OnActivated创建之后调用!"))
                  .OnRelease(e => Console.WriteLine("OnRelease在释放占用的资源之前调用!"));
            var Container = builder.Build();
            return new AutofacServiceProvider(Container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseMvc();

            var iocManager = app.ApplicationServices.GetService<IIocManager>();
            List<Parameter> cparams = new List<Parameter>();
            cparams.Add(new NamedParameter("name", "张三"));
            cparams.Add(new NamedParameter("sex", "男"));
            cparams.Add(new TypedParameter(typeof(int), 2));
            var testDemo = iocManager.Resolve<TestDemo>(cparams.ToArray());
            Console.WriteLine($"姓名：{testDemo.Name},年龄：{testDemo.Age},性别：{testDemo.Sex}");
        }
        public void More()
        {
        //    var iocManager = app.ApplicationServices.GetService<IIocManager>();
        //    List<Parameter> cparams = new List<Parameter>();
        //    cparams.Add(new NamedParameter("name", "张三"));
        //    cparams.Add(new NamedParameter("sex", "男"));
        //    cparams.Add(new TypedParameter(typeof(int), 2));
        //    var testDemo = iocManager.Resolve<TestDemo>(cparams.ToArray());
        //    Console.WriteLine($"姓名：{testDemo.Name},年龄：{testDemo.Age},性别：{testDemo.Sex}");


        }
        /// <summary>
        /// 1.RegisterType 
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            //注册Samoyed指定为IDog实现
            builder.RegisterType<Samoyed>().As<IDog>();
            builder.RegisterType<TibetanMastiff>().As<IDog>();
            using (var container = builder.Build())
            {
                var dogs = container.Resolve<IEnumerable<IDog>>();
                foreach (var dog in dogs)
                {
                    Console.WriteLine($"名称：{dog.Name},品种：{dog.Breed}");
                }
            }
        }

        /// <summary>
        /// 2.RegisterAssemblyTypes
        /// 　
        /// 3.RegisterInstance
        /// </summary>
        public static void RegisterAssemblyTypes()
        {
            var builder = new ContainerBuilder();
            //注册程序集下所有类型
            builder.RegisterAssemblyTypes(typeof(Program).Assembly).AsImplementedInterfaces();
            //直接注册程序集下的所有类型，AsImplementedInterfaces(让具体实现类型，可以该类型继承的所有接口类型找到该实现类型)
            using (var container = builder.Build())
            {
                var dogs = container.Resolve<IEnumerable<IDog>>();
                foreach (var dog in dogs)
                {
                    Console.WriteLine($"名称：{dog.Name},品种：{dog.Breed}");
                }
            }
            //3.RegisterInstance
            TibetanMastiff d = new TibetanMastiff();
            builder.RegisterInstance(d).As<IDog>();
        }
        ///4.RegisterModule
    }
}
