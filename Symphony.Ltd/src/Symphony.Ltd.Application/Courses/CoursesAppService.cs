using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Symphony.Ltd.Permissions;
using Symphony.Ltd.Courses;

namespace Symphony.Ltd.Courses
{

    [Authorize(LtdPermissions.Courses.Default)]
    public class CoursesAppService : LtdAppService, ICoursesAppService
    {

        protected ICourseRepository _courseRepository;
        protected CourseManager _courseManager;

        public CoursesAppService(ICourseRepository courseRepository, CourseManager courseManager)
        {

            _courseRepository = courseRepository;
            _courseManager = courseManager;
        }

        public virtual async Task<PagedResultDto<CourseDto>> GetListAsync(GetCoursesInput input)
        {
            var totalCount = await _courseRepository.GetCountAsync(input.FilterText, input.Title, input.Description, input.TeacherId, input.Price, input.TopicId, input.LearnTime);
            var items = await _courseRepository.GetListAsync(input.FilterText, input.Title, input.Description, input.TeacherId, input.Price, input.TopicId, input.LearnTime, input.Sorting, input.MaxResultCount, input.SkipCount);

            return new PagedResultDto<CourseDto>
            {
                TotalCount = totalCount,
                Items = ObjectMapper.Map<List<Course>, List<CourseDto>>(items)
            };
        }

        public virtual async Task<CourseDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<Course, CourseDto>(await _courseRepository.GetAsync(id));
        }

        [Authorize(LtdPermissions.Courses.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await _courseRepository.DeleteAsync(id);
        }

        [Authorize(LtdPermissions.Courses.Create)]
        public virtual async Task<CourseDto> CreateAsync(CourseCreateDto input)
        {

            var course = await _courseManager.CreateAsync(
            input.Title, input.Description, input.TeacherId, input.Price, input.TopicId, input.LearnTime
            );

            return ObjectMapper.Map<Course, CourseDto>(course);
        }

        [Authorize(LtdPermissions.Courses.Edit)]
        public virtual async Task<CourseDto> UpdateAsync(Guid id, CourseUpdateDto input)
        {

            var course = await _courseManager.UpdateAsync(
            id,
            input.Title, input.Description, input.TeacherId, input.Price, input.TopicId, input.LearnTime, input.ConcurrencyStamp
            );

            return ObjectMapper.Map<Course, CourseDto>(course);
        }
    }
}