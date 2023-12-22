using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MyShareModule.EntityFrameworkCore;

[ConnectionStringName(MyShareModuleDbProperties.ConnectionStringName)]
public class MyShareModuleDbContext : AbpDbContext<MyShareModuleDbContext>, IMyShareModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public MyShareModuleDbContext(DbContextOptions<MyShareModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureMyShareModule();
    }
}
