using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DotnetAngularDemo.Controllers
{
    public abstract class DotnetAngularDemoControllerBase: AbpController
    {
        protected DotnetAngularDemoControllerBase()
        {
            LocalizationSourceName = DotnetAngularDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
