using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Symphony.Ltd.Courses
{
    public interface ICoursesAppService : IApplicationService
    {

        Task<PagedResultDto<CourseDto>> GetListAsync(GetCoursesInput input);

        Task<CourseDto> GetAsync(Guid id);

        Task DeleteAsync(Guid id);

        Task<CourseDto> CreateAsync(CourseCreateDto input);

        Task<CourseDto> UpdateAsync(Guid id, CourseUpdateDto input);
    }
}