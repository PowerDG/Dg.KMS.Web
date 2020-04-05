using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace powerDg.KMS.Data
{
    /* This is used if database provider does't define
     * IKMSDbSchemaMigrator implementation.
     */
    public class NullKMSDbSchemaMigrator : IKMSDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}