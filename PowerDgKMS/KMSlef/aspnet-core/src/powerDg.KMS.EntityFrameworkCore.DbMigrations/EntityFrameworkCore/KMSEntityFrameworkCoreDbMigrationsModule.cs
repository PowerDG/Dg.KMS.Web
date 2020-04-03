using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace powerDg.KMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(KMSEntityFrameworkCoreModule)
        )]
    public class KMSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<KMSMigrationsDbContext>();
        }
    }
}
