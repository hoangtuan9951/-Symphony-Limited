using Volo.Abp.Modularity;

namespace Symphony.Ltd;

/* Inherit from this class for your domain layer tests. */
public abstract class LtdDomainTestBase<TStartupModule> : LtdTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
