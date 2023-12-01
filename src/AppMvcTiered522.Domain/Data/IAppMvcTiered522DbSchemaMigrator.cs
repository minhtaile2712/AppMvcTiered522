using System.Threading.Tasks;

namespace AppMvcTiered522.Data;

public interface IAppMvcTiered522DbSchemaMigrator
{
    Task MigrateAsync();
}
