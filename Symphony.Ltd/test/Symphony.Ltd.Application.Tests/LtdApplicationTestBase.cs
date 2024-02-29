using Volo.Abp.Modularity;

namespace Symphony.Ltd;

public abstract class LtdApplicationTestBase<TStartupModule> : LtdTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
