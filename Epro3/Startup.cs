using Epro3.Domain.Entities;
using Epro3.Infrastructure.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Epro3
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IServiceProvider _serviceProvider;
        public Startup(IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _configuration = configuration;
            _serviceProvider = serviceProvider;
        }
        public void ConfigureServices()
        {

        }
        public void Configure(IApplicationBuilder app)
        {
            bool conActive = false;
            while(!conActive)
            {
                try
                {
                    Thread.Sleep(1000);
                    using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                    {
                        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDatabaseContext>();
                        dbContext.Database.Migrate();
                    }
                    conActive = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public async Task Init()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var scopedServices = scope.ServiceProvider;
                try
                {
                    var dbContext = scopedServices.GetRequiredService<ApplicationDatabaseContext>();

                    Admin admin = new Admin
                    {
                        UserName = "admin",
                        Password = "admin"
                    };

                    dbContext.Admins.Add(admin);
                    await dbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
