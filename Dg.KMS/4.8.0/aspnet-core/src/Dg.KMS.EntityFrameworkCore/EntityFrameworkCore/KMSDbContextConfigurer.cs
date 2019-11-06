using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dg.KMS.EntityFrameworkCore
{
    public static class KMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KMSDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KMSDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
