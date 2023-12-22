using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace MyShareModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(MyShareModuleDomainSharedModule)
)]
public class MyShareModuleDomainModule : AbpModule
{

}
