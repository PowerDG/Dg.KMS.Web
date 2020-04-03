using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using dgPower.KMS.Authorization.Roles;
using dgPower.KMS.Authorization.Users;
using dgPower.KMS.MultiTenancy;

namespace dgPower.KMS.EntityFrameworkCore
{
    public class KMSDbContext : AbpZeroDbContext<Tenant, Role, User, KMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public KMSDbContext(DbContextOptions<KMSDbContext> options)
            : base(options)
        {
        }
    }
}
