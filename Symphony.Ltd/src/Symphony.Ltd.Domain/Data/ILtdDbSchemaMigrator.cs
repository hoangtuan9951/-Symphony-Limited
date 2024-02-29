using System.Threading.Tasks;

namespace Symphony.Ltd.Data;

public interface ILtdDbSchemaMigrator
{
    Task MigrateAsync();
}
