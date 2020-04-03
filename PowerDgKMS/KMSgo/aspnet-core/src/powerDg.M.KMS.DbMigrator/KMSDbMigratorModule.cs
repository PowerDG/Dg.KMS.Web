using powerDg.M.KMS.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace powerDg.M.KMS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(KMSMongoDbModule),
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
