using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dg.Fifth
{
    [DependsOn(
        typeof(FifthCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FifthApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FifthApplicationModule).GetAssembly());
        }
    }
}