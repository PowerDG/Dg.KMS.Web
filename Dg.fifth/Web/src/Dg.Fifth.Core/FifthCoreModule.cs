using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.Fifth.Localization;

namespace Dg.Fifth
{
    public class FifthCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            FifthLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FifthCoreModule).GetAssembly());
        }
    }
}