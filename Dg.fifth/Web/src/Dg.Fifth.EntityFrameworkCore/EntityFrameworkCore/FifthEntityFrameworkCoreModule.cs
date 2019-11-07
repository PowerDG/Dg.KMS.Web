using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Dg.Fifth.EntityFrameworkCore
{
    [DependsOn(
        typeof(FifthCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class FifthEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FifthEntityFrameworkCoreModule).GetAssembly());
        }
    }
}