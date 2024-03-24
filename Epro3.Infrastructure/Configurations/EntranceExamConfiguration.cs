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
    internal class EntranceExamConfiguration : IEntityTypeConfiguration<EntranceExam>
    {
        public void Configure(EntityTypeBuilder<EntranceExam> builder)
        {
            builder.ToTable("entranceExam");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.StartTime).HasColumnType("TIMESTAMP");
        }
    }
}
