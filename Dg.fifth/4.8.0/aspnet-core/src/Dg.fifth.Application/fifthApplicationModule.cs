using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.fifth.Authorization;

namespace Dg.fifth
{
    [DependsOn(
        typeof(fifthCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class fifthApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<fifthAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(fifthApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
