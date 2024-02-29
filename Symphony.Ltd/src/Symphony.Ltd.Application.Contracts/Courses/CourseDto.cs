using System;
using System.Collections.Generic;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Symphony.Ltd.Courses
{
    public class CourseDto : FullAuditedEntityDto<Guid>, IHasConcurrencyStamp
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? TeacherId { get; set; }
        public string? Price { get; set; }
        public Guid? TopicId { get; set; }
        public string? LearnTime { get; set; }

        public string ConcurrencyStamp { get; set; } = null!;

    }
}