using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dg.KMS.Authorization.Roles;
using Dg.KMS.Authorization.Users;
using Dg.KMS.MultiTenancy;

namespace Dg.KMS.EntityFrameworkCore
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
