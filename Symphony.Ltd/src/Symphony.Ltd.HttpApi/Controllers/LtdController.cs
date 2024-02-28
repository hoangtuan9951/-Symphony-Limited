using Symphony.Ltd.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Symphony.Ltd.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LtdController : AbpControllerBase
{
    protected LtdController()
    {
        LocalizationResource = typeof(LtdResource);
    }
}
