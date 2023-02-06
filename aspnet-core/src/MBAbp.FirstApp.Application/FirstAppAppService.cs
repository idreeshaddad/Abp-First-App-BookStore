using System;
using System.Collections.Generic;
using System.Text;
using MBAbp.FirstApp.Localization;
using Volo.Abp.Application.Services;

namespace MBAbp.FirstApp;

/* Inherit your application services from this class.
 */
public abstract class FirstAppAppService : ApplicationService
{
    protected FirstAppAppService()
    {
        LocalizationResource = typeof(FirstAppResource);
    }
}
