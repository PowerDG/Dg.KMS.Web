using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dgPower.PKMS.EntityFrameworkCore
{
    public static class PKMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PKMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PKMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
