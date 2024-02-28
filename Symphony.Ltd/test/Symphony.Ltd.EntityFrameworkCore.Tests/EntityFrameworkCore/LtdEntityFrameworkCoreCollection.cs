using Xunit;

namespace Symphony.Ltd.EntityFrameworkCore;

[CollectionDefinition(LtdTestConsts.CollectionDefinitionName)]
public class LtdEntityFrameworkCoreCollection : ICollectionFixture<LtdEntityFrameworkCoreFixture>
{

}
