using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.fifth.Configuration;

namespace Dg.fifth.Web.Host.Startup
{
    [DependsOn(
       typeof(fifthWebCoreModule))]
    public class fifthWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public fifthWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(fifthWebHostModule).GetAssembly());
        }
    }
}
