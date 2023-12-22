using MyShareModule.Localization;
using Volo.Abp.Application.Services;

namespace MyShareModule;

public abstract class MyShareModuleAppService : ApplicationService
{
    protected MyShareModuleAppService()
    {
        LocalizationResource = typeof(MyShareModuleResource);
        ObjectMapperContext = typeof(MyShareModuleApplicationModule);
    }
}
