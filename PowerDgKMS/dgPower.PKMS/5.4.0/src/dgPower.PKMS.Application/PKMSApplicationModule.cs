using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgPower.PKMS.Authorization;

namespace dgPower.PKMS
{
    [DependsOn(
        typeof(PKMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PKMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PKMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PKMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
