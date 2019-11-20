using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.DynamicProxy;
using Autofac.Integration.WebApi;
using KMS.Twelve.Controllers;
using KMS.Twelve.Test;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace KMS.Twelve
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IContainer AutofacContainer;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// ASP.NET Core中的Autofac
        /// 首先在Project.json的Dependency节点为中添加如下引用：
        /// "Microsoft.Extensions.DependencyInjection": "1.0.0",
        /// "Autofac.Extensions.DependencyInjection": "4.0.0",
        /// 接着我们也修改Startup文件中的ConfigureServices方法，
        /// 为了接管默认的DI，我们要为函数添加返回值AutofacServiceProvider;
        /// 【ASP.NET Core如何替换其它的IOC容器】
        /// 这会给我们的初始化带来一些便利性，我们来看看如何替换Autofac到ASP.NET Core。
        /// 我们只需要把Startup类里面的 ConfigureService的 返回值从 void改为 IServiceProvider即可。
        /// 而返回的则是一个AutoServiceProvider。
        ///作者：段邵华
        ///链接：https://www.jianshu.com/p/e83afc8e80fd
        ///来源：简书
        ///著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。

        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //services.AddApplicationInsightsTelemetry(Configuration);
            //替换控制器所有者
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddMvc();
            //services.AddDbContext<BloggingContext>();

            services.AddDirectoryBrowser();
            var containerBuilder = new ContainerBuilder();
            ////属性注入控制器
            //containerBuilder.RegisterType<AutoDIController>().PropertiesAutowired();

            //模块化注入
            containerBuilder.RegisterModule<DefaultModule>();

            containerBuilder.RegisterModule<DefaultModuleRegister>();
            //containerBuilder.RegisterTypes(Controllers.Select(ti => ti.AsType()).ToArray()).PropertiesAutowired();
            containerBuilder.Populate(services);
            //创建容器.
            AutofacContainer = containerBuilder.Build();
            //使用容器创建 AutofacServiceProvider
            return new AutofacServiceProvider(AutofacContainer);
            //return RegisterAutofac(services);

            //            其中很大的一个变化在于，Autofac 原来的一个生命周期InstancePerRequest，将不再有效。
            //            正如我们前面所说的，整个request的生命周期被ASP.NET Core管理了，所以Autofac的这个将不再有效。
            //            我们可以使用 InstancePerLifetimeScope ，同样是有用的，对应了我们ASP.NET Core DI 里面的Scoped。

            //作者：段邵华
            //链接：https://www.jianshu.com/p/e83afc8e80fd
            //            来源：简书
            //            著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
            //        
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

            #endregion Old【ConfigureServices】

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app
                , IHostingEnvironment env
                , IApplicationLifetime appLifetime)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseMvc();
                //程序停止调用函数
                appLifetime.ApplicationStopped.Register(() => { AutofacContainer.Dispose(); });
            }

            /// <summary>
            /// NET Core 整合Autofac和Castle
            /// https://www.cnblogs.com/Leo_wl/p/5936941.html
            /// ASP.NET Core 整合Autofac和Castle实现自动AOP拦截 (2016-10-17 13:15:12)
            /// http://blog.sina.com.cn/s/blog_16544e8090102x922.html
            ///

            /// </summary>
            /// <param name="services"></param>
            /// <returns></returns>
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
                AutofacContainer = builder.Build();
                return new AutofacServiceProvider(AutofacContainer);
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