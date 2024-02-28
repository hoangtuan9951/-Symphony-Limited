using Symphony.Ltd.Localization;
using Volo.Abp.Application.Services;

namespace Symphony.Ltd;

/* Inherit your application services from this class.
 */
public abstract class LtdAppService : ApplicationService
{
    protected LtdAppService()
    {
        LocalizationResource = typeof(LtdResource);
    }
}
