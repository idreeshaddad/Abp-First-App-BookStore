using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MBAbp.FirstApp.Data;

/* This is used if database provider does't define
 * IFirstAppDbSchemaMigrator implementation.
 */
public class NullFirstAppDbSchemaMigrator : IFirstAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
