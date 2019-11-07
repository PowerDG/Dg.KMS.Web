using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.Fifth.Configuration;
using Dg.Fifth.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Dg.Fifth.Web.Startup
{
    [DependsOn(
        typeof(FifthApplicationModule), 
        typeof(FifthEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class FifthWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public FifthWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(FifthConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<FifthNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(FifthApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FifthWebModule).GetAssembly());
        }
    }
}