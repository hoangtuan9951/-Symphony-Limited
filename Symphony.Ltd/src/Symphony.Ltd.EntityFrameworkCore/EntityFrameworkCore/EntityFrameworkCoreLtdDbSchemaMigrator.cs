using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Symphony.Ltd.Data;
using Volo.Abp.DependencyInjection;

namespace Symphony.Ltd.EntityFrameworkCore;

public class EntityFrameworkCoreLtdDbSchemaMigrator
    : ILtdDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLtdDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the LtdDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LtdDbContext>()
            .Database
            .MigrateAsync();
    }
}
