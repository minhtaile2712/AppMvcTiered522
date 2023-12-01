using AppMvcTiered522.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AppMvcTiered522;

[DependsOn(
    typeof(AppMvcTiered522EntityFrameworkCoreTestModule)
    )]
public class AppMvcTiered522DomainTestModule : AbpModule
{

}
