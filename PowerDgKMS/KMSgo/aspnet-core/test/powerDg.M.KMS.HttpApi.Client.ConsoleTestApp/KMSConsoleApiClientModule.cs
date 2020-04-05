using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace powerDg.M.KMS.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(KMSHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class KMSConsoleApiClientModule : AbpModule
    {
        
    }
}
