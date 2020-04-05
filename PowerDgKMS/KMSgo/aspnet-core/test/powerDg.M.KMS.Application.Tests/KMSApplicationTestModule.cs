using Volo.Abp.Modularity;

namespace powerDg.M.KMS
{
    [DependsOn(
        typeof(KMSApplicationModule),
        typeof(KMSDomainTestModule)
        )]
    public class KMSApplicationTestModule : AbpModule
    {

    }
}