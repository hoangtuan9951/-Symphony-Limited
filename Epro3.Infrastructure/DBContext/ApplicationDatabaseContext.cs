using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epro3.Domain.Entities;
using Epro3.Infrastructure.Configurations;
using Epro3.Infrastructure.Extension;
using Microsoft.EntityFrameworkCore;

namespace Epro3.Infrastructure.DBContext
{
    public class ApplicationDatabaseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.SeedData();
        }
    }
}
