using System.Threading.Tasks;

namespace powerDg.M.KMS.Data
{
    public interface IKMSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
