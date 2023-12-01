using AppMvcTiered522.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AppMvcTiered522.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppMvcTiered522EntityFrameworkCoreModule),
    typeof(AppMvcTiered522ApplicationContractsModule)
    )]
public class AppMvcTiered522DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
