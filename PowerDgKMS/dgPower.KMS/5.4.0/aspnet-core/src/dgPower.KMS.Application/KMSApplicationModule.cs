﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgPower.KMS.Authorization;

namespace dgPower.KMS
{
    [DependsOn(
        typeof(KMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
