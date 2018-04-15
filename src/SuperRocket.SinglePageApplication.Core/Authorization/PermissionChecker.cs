using Abp.Authorization;
using SuperRocket.SinglePageApplication.Authorization.Roles;
using SuperRocket.SinglePageApplication.Authorization.Users;

namespace SuperRocket.SinglePageApplication.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
