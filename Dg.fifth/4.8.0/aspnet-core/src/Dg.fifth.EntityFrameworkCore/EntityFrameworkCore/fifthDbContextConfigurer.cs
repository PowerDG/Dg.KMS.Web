using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dg.fifth.EntityFrameworkCore
{
    public static class fifthDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<fifthDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<fifthDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
