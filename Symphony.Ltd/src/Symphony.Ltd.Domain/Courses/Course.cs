using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using JetBrains.Annotations;

using Volo.Abp;

namespace Symphony.Ltd.Courses
{
    public class Course : FullAuditedAggregateRoot<Guid>
    {
        [CanBeNull]
        public virtual string? Title { get; set; }

        [CanBeNull]
        public virtual string? Description { get; set; }

        public virtual Guid? TeacherId { get; set; }

        [CanBeNull]
        public virtual string? Price { get; set; }

        public virtual Guid? TopicId { get; set; }

        [CanBeNull]
        public virtual string? LearnTime { get; set; }

        protected Course()
        {

        }

        public Course(Guid id, string? title = null, string? description = null, Guid? teacherId = null, string? price = null, Guid? topicId = null, string? learnTime = null)
        {

            Id = id;
            Title = title;
            Description = description;
            TeacherId = teacherId;
            Price = price;
            TopicId = topicId;
            LearnTime = learnTime;
        }

    }
}