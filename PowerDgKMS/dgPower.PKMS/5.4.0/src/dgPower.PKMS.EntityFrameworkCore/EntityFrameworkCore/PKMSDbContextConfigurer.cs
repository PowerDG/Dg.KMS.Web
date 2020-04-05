using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dgPower.PKMS.EntityFrameworkCore
{
    public static class PKMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PKMSDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PKMSDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
