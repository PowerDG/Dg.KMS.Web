using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dg.Fifth.EntityFrameworkCore
{
    public class FifthDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public FifthDbContext(DbContextOptions<FifthDbContext> options) 
            : base(options)
        {

        }
    }
}
