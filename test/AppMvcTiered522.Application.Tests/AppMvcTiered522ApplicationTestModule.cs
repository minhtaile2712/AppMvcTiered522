using Volo.Abp.Modularity;

namespace AppMvcTiered522;

[DependsOn(
    typeof(AppMvcTiered522ApplicationModule),
    typeof(AppMvcTiered522DomainTestModule)
    )]
public class AppMvcTiered522ApplicationTestModule : AbpModule
{

}
