using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dg.fifth.Configuration;
using Dg.fifth.Web;

namespace Dg.fifth.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class fifthDbContextFactory : IDesignTimeDbContextFactory<fifthDbContext>
    {
        public fifthDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<fifthDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            fifthDbContextConfigurer.Configure(builder, configuration.GetConnectionString(fifthConsts.ConnectionStringName));

            return new fifthDbContext(builder.Options);
        }
    }
}
