using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace MyShareModule;

[DependsOn(
    typeof(MyShareModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class MyShareModuleApplicationContractsModule : AbpModule
{

}
