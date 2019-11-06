using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.KMS.Configuration;

namespace Dg.KMS.Web.Host.Startup
{
    [DependsOn(
       typeof(KMSWebCoreModule))]
    public class KMSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KMSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KMSWebHostModule).GetAssembly());
        }
    }
}
