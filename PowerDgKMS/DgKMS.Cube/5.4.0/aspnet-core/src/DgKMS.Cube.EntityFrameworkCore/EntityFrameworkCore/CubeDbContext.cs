using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DgKMS.Cube.Authorization.Roles;
using DgKMS.Cube.Authorization.Users;
using DgKMS.Cube.MultiTenancy;

namespace DgKMS.Cube.EntityFrameworkCore
{
    public class CubeDbContext : AbpZeroDbContext<Tenant, Role, User, CubeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CubeDbContext(DbContextOptions<CubeDbContext> options)
            : base(options)
        {
        }
    }
}
