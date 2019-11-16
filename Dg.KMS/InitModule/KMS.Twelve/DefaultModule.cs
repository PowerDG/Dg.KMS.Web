using Autofac;
using Autofac.Extras.DynamicProxy;
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

            builder.Register(c => new AOPTest());
            //加上EnableInterfaceInterceptors来开启你的拦截.
            builder.RegisterType<TestService>().As<ITestService>()
                .PropertiesAutowired().EnableInterfaceInterceptors();

        }
    }
}