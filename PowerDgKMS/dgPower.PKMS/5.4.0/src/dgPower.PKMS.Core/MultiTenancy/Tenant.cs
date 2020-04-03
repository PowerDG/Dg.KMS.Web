using Abp.MultiTenancy;
using dgPower.PKMS.Authorization.Users;

namespace dgPower.PKMS.MultiTenancy
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
