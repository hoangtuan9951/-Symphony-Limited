using Symphony.Ltd.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Symphony.Ltd.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LtdEntityFrameworkCoreModule),
    typeof(LtdApplicationContractsModule)
)]
public class LtdDbMigratorModule : AbpModule
{
}
