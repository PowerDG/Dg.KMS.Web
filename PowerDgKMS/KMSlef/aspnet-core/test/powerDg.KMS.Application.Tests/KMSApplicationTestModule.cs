using Volo.Abp.Modularity;

namespace powerDg.KMS
{
    [DependsOn(
        typeof(KMSApplicationModule),
        typeof(KMSDomainTestModule)
        )]
    public class KMSApplicationTestModule : AbpModule
    {

    }
}