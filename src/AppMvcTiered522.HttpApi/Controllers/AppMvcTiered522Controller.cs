using AppMvcTiered522.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AppMvcTiered522.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AppMvcTiered522Controller : AbpControllerBase
{
    protected AppMvcTiered522Controller()
    {
        LocalizationResource = typeof(AppMvcTiered522Resource);
    }
}
