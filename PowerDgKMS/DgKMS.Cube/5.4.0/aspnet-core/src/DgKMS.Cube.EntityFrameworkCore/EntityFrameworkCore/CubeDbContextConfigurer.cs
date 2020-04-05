using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DgKMS.Cube.EntityFrameworkCore
{
    public static class CubeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CubeDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CubeDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
