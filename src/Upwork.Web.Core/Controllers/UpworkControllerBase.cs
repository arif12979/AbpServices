using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Upwork.Controllers
{
    public abstract class UpworkControllerBase: AbpController
    {
        protected UpworkControllerBase()
        {
            LocalizationSourceName = UpworkConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
