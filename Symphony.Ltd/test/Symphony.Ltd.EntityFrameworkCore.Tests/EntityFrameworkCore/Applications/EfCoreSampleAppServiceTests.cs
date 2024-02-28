using Symphony.Ltd.Samples;
using Xunit;

namespace Symphony.Ltd.EntityFrameworkCore.Applications;

[Collection(LtdTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LtdEntityFrameworkCoreTestModule>
{

}
