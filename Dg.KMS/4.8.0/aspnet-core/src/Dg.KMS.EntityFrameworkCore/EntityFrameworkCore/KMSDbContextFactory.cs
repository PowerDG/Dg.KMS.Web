using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dg.KMS.Configuration;
using Dg.KMS.Web;

namespace Dg.KMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KMSDbContextFactory : IDesignTimeDbContextFactory<KMSDbContext>
    {
        public KMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KMSConsts.ConnectionStringName));

            return new KMSDbContext(builder.Options);
        }
    }
}
