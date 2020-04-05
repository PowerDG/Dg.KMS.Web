using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgKMS.Cube.Configuration;

namespace DgKMS.Cube.Web.Host.Startup
{
    [DependsOn(
       typeof(CubeWebCoreModule))]
    public class CubeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CubeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CubeWebHostModule).GetAssembly());
        }
    }
}
