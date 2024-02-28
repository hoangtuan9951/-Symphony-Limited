using Symphony.Ltd.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Symphony.Ltd.Web.Pages;

public abstract class LtdPageModel : AbpPageModel
{
    protected LtdPageModel()
    {
        LocalizationResourceType = typeof(LtdResource);
    }
}
