using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using DgKMS.Cube.Configuration;
using DgKMS.Cube.Web;

namespace DgKMS.Cube.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CubeDbContextFactory : IDesignTimeDbContextFactory<CubeDbContext>
    {
        public CubeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CubeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CubeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CubeConsts.ConnectionStringName));

            return new CubeDbContext(builder.Options);
        }
    }
}
