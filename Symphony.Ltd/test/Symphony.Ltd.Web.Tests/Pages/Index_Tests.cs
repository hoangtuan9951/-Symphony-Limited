using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Symphony.Ltd.Pages;

[Collection(LtdTestConsts.CollectionDefinitionName)]
public class Index_Tests : LtdWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
