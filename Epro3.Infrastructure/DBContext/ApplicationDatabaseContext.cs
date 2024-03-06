using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Epro3.Infrastructure.DBContext
{
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }
    }
}
