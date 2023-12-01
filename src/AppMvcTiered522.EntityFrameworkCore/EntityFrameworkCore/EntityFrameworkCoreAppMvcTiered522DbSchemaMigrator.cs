using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AppMvcTiered522.Data;
using Volo.Abp.DependencyInjection;

namespace AppMvcTiered522.EntityFrameworkCore;

public class EntityFrameworkCoreAppMvcTiered522DbSchemaMigrator
    : IAppMvcTiered522DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAppMvcTiered522DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AppMvcTiered522DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AppMvcTiered522DbContext>()
            .Database
            .MigrateAsync();
    }
}
