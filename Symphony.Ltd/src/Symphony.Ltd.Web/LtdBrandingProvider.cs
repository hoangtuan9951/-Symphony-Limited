using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Symphony.Ltd.Web;

[Dependency(ReplaceServices = true)]
public class LtdBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Ltd";
}
