using Dg.Fifth.Configuration;
using Dg.Fifth.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dg.Fifth.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class FifthDbContextFactory : IDesignTimeDbContextFactory<FifthDbContext>
    {
        public FifthDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FifthDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(FifthConsts.ConnectionStringName)
            );

            return new FifthDbContext(builder.Options);
        }
    }
}