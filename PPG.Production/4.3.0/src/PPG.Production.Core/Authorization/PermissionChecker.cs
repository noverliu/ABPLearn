using Abp.Authorization;
using PPG.Production.Authorization.Roles;
using PPG.Production.Authorization.Users;

namespace PPG.Production.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
