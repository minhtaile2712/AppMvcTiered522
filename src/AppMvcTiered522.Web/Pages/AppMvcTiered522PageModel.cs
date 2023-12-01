using AppMvcTiered522.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AppMvcTiered522.Web.Pages;

public abstract class AppMvcTiered522PageModel : AbpPageModel
{
    protected AppMvcTiered522PageModel()
    {
        LocalizationResourceType = typeof(AppMvcTiered522Resource);
    }
}
