using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dg.fifth.Authorization.Roles;
using Dg.fifth.Authorization.Users;
using Dg.fifth.MultiTenancy;

namespace Dg.fifth.EntityFrameworkCore
{
    public class fifthDbContext : AbpZeroDbContext<Tenant, Role, User, fifthDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public fifthDbContext(DbContextOptions<fifthDbContext> options)
            : base(options)
        {
        }
    }
}
