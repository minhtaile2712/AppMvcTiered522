using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AppMvcTiered522.Data;

/* This is used if database provider does't define
 * IAppMvcTiered522DbSchemaMigrator implementation.
 */
public class NullAppMvcTiered522DbSchemaMigrator : IAppMvcTiered522DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
