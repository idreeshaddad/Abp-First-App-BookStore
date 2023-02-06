using MBAbp.FirstApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MBAbp.FirstApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FirstAppController : AbpControllerBase
{
    protected FirstAppController()
    {
        LocalizationResource = typeof(FirstAppResource);
    }
}
