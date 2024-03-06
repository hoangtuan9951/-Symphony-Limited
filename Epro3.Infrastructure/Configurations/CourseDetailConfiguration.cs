using Epro3.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Configurations
{
    internal class CourseDetailConfiguration : IEntityTypeConfiguration<CourseDetail>
    {
        public void Configure(EntityTypeBuilder<CourseDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
