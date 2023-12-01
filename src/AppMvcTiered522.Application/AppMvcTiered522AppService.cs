using System;
using System.Collections.Generic;
using System.Text;
using AppMvcTiered522.Localization;
using Volo.Abp.Application.Services;

namespace AppMvcTiered522;

/* Inherit your application services from this class.
 */
public abstract class AppMvcTiered522AppService : ApplicationService
{
    protected AppMvcTiered522AppService()
    {
        LocalizationResource = typeof(AppMvcTiered522Resource);
    }
}
