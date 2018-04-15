using Abp.MultiTenancy;
using SuperRocket.SinglePageApplication.Authorization.Users;

namespace SuperRocket.SinglePageApplication.MultiTenancy
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