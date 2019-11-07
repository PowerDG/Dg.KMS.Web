using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dg.Fifth.Web.Startup;
namespace Dg.Fifth.Web.Tests
{
    [DependsOn(
        typeof(FifthWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class FifthWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FifthWebTestModule).GetAssembly());
        }
    }
}