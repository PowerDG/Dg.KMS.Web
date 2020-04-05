using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgPower.PKMS.Configuration;

namespace dgPower.PKMS.Web.Host.Startup
{
    [DependsOn(
       typeof(PKMSWebCoreModule))]
    public class PKMSWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PKMSWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PKMSWebHostModule).GetAssembly());
        }
    }
}
