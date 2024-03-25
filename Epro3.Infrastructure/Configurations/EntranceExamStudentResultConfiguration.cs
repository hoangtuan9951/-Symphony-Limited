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
    internal class EntranceExamStudentResultConfiguration : IEntityTypeConfiguration<EntranceExamStudentResult>
    {
        public void Configure(EntityTypeBuilder<EntranceExamStudentResult> builder)
        {
            builder.ToTable("entranceExamStudentResult");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.HasOne(e => e.Student).WithOne(e => e.EntranceExamStudentResult).HasForeignKey<EntranceExamStudentResult>(e => e.StudentRollNumber);
            builder.HasOne(e => e.EntranceExam).WithMany(e => e.EntranceExamStudentResults).HasForeignKey(e => e.EntranceExamId);
            builder.HasOne(e => e.Course).WithMany(e => e.EntranceExamStudentResults).HasForeignKey(e => e.CourseId);
        }
    }
}
