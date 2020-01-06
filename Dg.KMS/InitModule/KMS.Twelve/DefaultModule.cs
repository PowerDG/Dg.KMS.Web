using Autofac;
using Autofac.Extras.DynamicProxy;
using KMS.Twelve.Controllers;
using KMS.Twelve.Message;
using KMS.Twelve.Test;
using System.Linq;
using System.Reflection;
using Module = Autofac.Module;

namespace KMS.Twelve
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ////注入测试服务
            //builder.RegisterType<TestService>().As<ITestService>();

            //属性注入
            //builder.RegisterType<TestService>().As<ITestService>().PropertiesAutowired();

            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterType<InMemoryCache>().As<ICache>().InstancePerLifetimeScope();

            // Register 方式指定具体类
            builder.Register(c => new InjectionTestService()).As<IService>().InstancePerDependency();

            // RegisterType 方式指定具体类
            builder.RegisterType<InjectionTestService>().As<IService>().InstancePerDependency();

            // 自动注入的方式，不需要知道具体类的名称

            /* BuildManager.GetReferencedAssemblies()
             * 程序集的集合，包含 Web.config 文件的 assemblies 元素中指定的程序集、
             * 从 App_Code 目录中的自定义代码生成的程序集以及其他顶级文件夹中的程序集。
             *
             * 依赖注入之Autofac使用总结
             * https://www.cnblogs.com/struggle999/p/6986903.html
             */

            // 获取包含继承了IService接口类的程序集
            var allAssemblies = Assembly.GetEntryAssembly()
                .GetReferencedAssemblies()
                .Select(Assembly.Load)
                .Where(
                    assembly =>
                        assembly.GetTypes().FirstOrDefault(type => type.GetInterfaces()
                            .Contains(typeof(IService))) != null
                )
                ;

            // RegisterAssemblyTypes 注册程序集
            //.net core如何读取所有页面的程序集
            //    https://q.cnblogs.com/q/113026/
            var enumerable = allAssemblies as Assembly[] ?? allAssemblies.ToArray();
            if (enumerable.Any())
            {
                builder.RegisterAssemblyTypes(enumerable)
                    .Where(type => type.GetInterfaces().Contains(typeof(IService))).AsSelf().InstancePerDependency();
            }

            //containerBuilder.RegisterType<AutoDIController>().PropertiesAutowired();
            builder.RegisterAssemblyTypes(typeof(AutoDIController).Assembly)
                .Where(t => t.Name.EndsWith("Controller") || t.Name.EndsWith("AppService")).PropertiesAutowired();
            //builder.RegisterAssemblyTypes(typeof(StuEducationRepo).Assembly)
            //    .Where(t => t.Name.EndsWith("Repo"))
            //    .AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof(StudentRegisterDmnService).Assembly)
            //    .Where(t => t.Name.EndsWith("DmnService"))
            //    .AsImplementedInterfaces().InstancePerLifetimeScope();
            //builder.RegisterAssemblyTypes(typeof(StuEducationAppService).Assembly)
            //    .Where(t => t.Name.EndsWith("AppService"))

            //属性注入控制器
            //containerBuilder.RegisterType<AutoDIController>().PropertiesAutowired();

            builder.Register(c => new AOPTest());
            //加上EnableInterfaceInterceptors来开启你的拦截.
            builder.RegisterType<TestService>().As<ITestService>()
                .PropertiesAutowired().EnableInterfaceInterceptors();


                        typeof(IMessage).Assembly.GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IMessage))).ToList()
            .ForEach(type =>
            {
                builder.RegisterType(type);
                //builder.RegisterType<type>();
                // 注册type
            });


        }
    }
}