using Epro3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("course");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.StartedDate).HasColumnType("TIMESTAMP");
            builder.Property(e => e.EndedDate).HasColumnType("TIMESTAMP");
            builder.Property(e => e.FeeChagreDate).HasColumnType("TIMESTAMP");
            builder.Property(e => e.CreatedDate).HasColumnType("TIMESTAMP");
        }
    }
}
