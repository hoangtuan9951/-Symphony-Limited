using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Data;

namespace Symphony.Ltd.Courses
{
    public class CourseManager : DomainService
    {
        protected ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public virtual async Task<Course> CreateAsync(
        string? title = null, string? description = null, Guid? teacherId = null, string? price = null, Guid? topicId = null, string? learnTime = null)
        {

            var course = new Course(
             GuidGenerator.Create(),
             title, description, teacherId, price, topicId, learnTime
             );

            return await _courseRepository.InsertAsync(course);
        }

        public virtual async Task<Course> UpdateAsync(
            Guid id,
            string? title = null, string? description = null, Guid? teacherId = null, string? price = null, Guid? topicId = null, string? learnTime = null, [CanBeNull] string? concurrencyStamp = null
        )
        {

            var course = await _courseRepository.GetAsync(id);

            course.Title = title;
            course.Description = description;
            course.TeacherId = teacherId;
            course.Price = price;
            course.TopicId = topicId;
            course.LearnTime = learnTime;

            course.SetConcurrencyStampIfNotNull(concurrencyStamp);
            return await _courseRepository.UpdateAsync(course);
        }

    }
}