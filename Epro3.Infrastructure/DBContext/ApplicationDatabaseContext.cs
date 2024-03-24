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
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<EntranceExam> EntranceExams { get; set; }
        public DbSet<EntranceExamStudentResult> EntranceExamStudentResults { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Student> Students { get; set; }
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModuleConfiguration());
            modelBuilder.ApplyConfiguration(new EntranceExamConfiguration());
            modelBuilder.ApplyConfiguration(new EntranceExamStudentResultConfiguration());
            modelBuilder.ApplyConfiguration(new FAQConfiguration());
            modelBuilder.SeedData();
        }
    }
}
