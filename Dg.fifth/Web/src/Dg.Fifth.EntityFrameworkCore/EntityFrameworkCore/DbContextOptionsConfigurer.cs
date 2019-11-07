using Microsoft.EntityFrameworkCore;

namespace Dg.Fifth.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<FifthDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for FifthDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
