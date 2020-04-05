using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dgPower.KMS.EntityFrameworkCore
{
    public static class KMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
