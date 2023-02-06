using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MBAbp.FirstApp.Data;
using Volo.Abp.DependencyInjection;

namespace MBAbp.FirstApp.EntityFrameworkCore;

public class EntityFrameworkCoreFirstAppDbSchemaMigrator
    : IFirstAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFirstAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FirstAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FirstAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
