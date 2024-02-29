using Symphony.Ltd.Samples;
using Xunit;

namespace Symphony.Ltd.EntityFrameworkCore.Domains;

[Collection(LtdTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LtdEntityFrameworkCoreTestModule>
{

}
