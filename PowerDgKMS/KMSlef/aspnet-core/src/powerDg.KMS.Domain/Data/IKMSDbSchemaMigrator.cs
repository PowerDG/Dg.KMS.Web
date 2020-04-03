using System.Threading.Tasks;

namespace powerDg.KMS.Data
{
    public interface IKMSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
