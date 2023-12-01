using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AppMvcTiered522;

[Dependency(ReplaceServices = true)]
public class AppMvcTiered522BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AppMvcTiered522";
}
