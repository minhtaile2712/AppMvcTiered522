using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyShareModule.EntityFrameworkCore;

[ConnectionStringName(MyShareModuleDbProperties.ConnectionStringName)]
public interface IMyShareModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
