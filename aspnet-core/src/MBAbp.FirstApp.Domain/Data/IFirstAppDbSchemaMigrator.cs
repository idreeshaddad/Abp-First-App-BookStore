using System.Threading.Tasks;

namespace MBAbp.FirstApp.Data;

public interface IFirstAppDbSchemaMigrator
{
    Task MigrateAsync();
}
