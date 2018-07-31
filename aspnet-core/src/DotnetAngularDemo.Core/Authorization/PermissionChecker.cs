using Abp.Authorization;
using DotnetAngularDemo.Authorization.Roles;
using DotnetAngularDemo.Authorization.Users;

namespace DotnetAngularDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
