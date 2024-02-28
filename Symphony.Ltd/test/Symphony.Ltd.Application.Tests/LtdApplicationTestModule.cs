using Volo.Abp.Modularity;

namespace Symphony.Ltd;

[DependsOn(
    typeof(LtdApplicationModule),
    typeof(LtdDomainTestModule)
)]
public class LtdApplicationTestModule : AbpModule
{

}
