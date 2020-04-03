using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using dgPower.PKMS.Configuration;
using dgPower.PKMS.Web;

namespace dgPower.PKMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PKMSDbContextFactory : IDesignTimeDbContextFactory<PKMSDbContext>
    {
        public PKMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PKMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PKMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PKMSConsts.ConnectionStringName));

            return new PKMSDbContext(builder.Options);
        }
    }
}
