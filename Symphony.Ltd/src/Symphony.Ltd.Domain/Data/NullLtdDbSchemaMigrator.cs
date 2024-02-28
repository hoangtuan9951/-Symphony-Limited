using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Symphony.Ltd.Data;

/* This is used if database provider does't define
 * ILtdDbSchemaMigrator implementation.
 */
public class NullLtdDbSchemaMigrator : ILtdDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
