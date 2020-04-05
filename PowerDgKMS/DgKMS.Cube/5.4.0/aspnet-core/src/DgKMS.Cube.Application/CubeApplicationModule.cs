using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DgKMS.Cube.Authorization;

namespace DgKMS.Cube
{
    [DependsOn(
        typeof(CubeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CubeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CubeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CubeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
