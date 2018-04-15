using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using SuperRocket.SinglePageApplication.Authorization.Users;
using SuperRocket.SinglePageApplication.MultiTenancy;
using SuperRocket.SinglePageApplication.Users;
using Microsoft.AspNet.Identity;

namespace SuperRocket.SinglePageApplication
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SinglePageApplicationAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected SinglePageApplicationAppServiceBase()
        {
            LocalizationSourceName = SinglePageApplicationConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}