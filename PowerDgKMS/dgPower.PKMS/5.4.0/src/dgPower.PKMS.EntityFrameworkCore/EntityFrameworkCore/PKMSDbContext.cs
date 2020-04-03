using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using dgPower.PKMS.Authorization.Roles;
using dgPower.PKMS.Authorization.Users;
using dgPower.PKMS.MultiTenancy;

namespace dgPower.PKMS.EntityFrameworkCore
{
    public class PKMSDbContext : AbpZeroDbContext<Tenant, Role, User, PKMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PKMSDbContext(DbContextOptions<PKMSDbContext> options)
            : base(options)
        {
        }
    }
}
