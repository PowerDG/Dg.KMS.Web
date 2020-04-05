using powerDg.KMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace powerDg.KMS
{
    [DependsOn(
        typeof(KMSEntityFrameworkCoreTestModule)
        )]
    public class KMSDomainTestModule : AbpModule
    {

    }
}