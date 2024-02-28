using Microsoft.AspNetCore.Builder;
using Symphony.Ltd;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<LtdWebTestModule>();

public partial class Program
{
}
