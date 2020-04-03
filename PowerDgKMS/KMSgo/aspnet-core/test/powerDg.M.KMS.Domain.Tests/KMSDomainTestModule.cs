using powerDg.M.KMS.MongoDB;
using Volo.Abp.Modularity;

namespace powerDg.M.KMS
{
    [DependsOn(
        typeof(KMSMongoDbTestModule)
        )]
    public class KMSDomainTestModule : AbpModule
    {

    }
}