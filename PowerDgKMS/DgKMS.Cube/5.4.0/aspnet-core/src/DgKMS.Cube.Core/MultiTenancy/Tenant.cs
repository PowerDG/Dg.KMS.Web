using Abp.MultiTenancy;
using DgKMS.Cube.Authorization.Users;

namespace DgKMS.Cube.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
