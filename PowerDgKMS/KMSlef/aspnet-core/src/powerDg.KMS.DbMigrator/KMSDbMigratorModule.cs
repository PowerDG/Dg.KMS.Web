using powerDg.KMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace powerDg.KMS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(KMSEntityFrameworkCoreDbMigrationsModule),
        typeof(KMSApplicationContractsModule)
        )]
    public class KMSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
