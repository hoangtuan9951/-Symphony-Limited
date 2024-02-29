using Volo.Abp.Modularity;

namespace Symphony.Ltd;

[DependsOn(
    typeof(LtdDomainModule),
    typeof(LtdTestBaseModule)
)]
public class LtdDomainTestModule : AbpModule
{

}
