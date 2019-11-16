using Autofac;
using Autofac.Extras.DynamicProxy;
using KMS.Twelve.Controllers;
using KMS.Twelve.Test;

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

        }
    }
}