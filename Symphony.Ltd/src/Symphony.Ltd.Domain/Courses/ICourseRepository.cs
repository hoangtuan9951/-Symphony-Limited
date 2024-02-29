using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Symphony.Ltd.Courses
{
    public interface ICourseRepository : IRepository<Course, Guid>
    {
        Task<List<Course>> GetListAsync(
            string? filterText = null,
            string? title = null,
            string? description = null,
            Guid? teacherId = null,
            string? price = null,
            Guid? topicId = null,
            string? learnTime = null,
            string? sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            CancellationToken cancellationToken = default
        );

        Task<long> GetCountAsync(
            string? filterText = null,
            string? title = null,
            string? description = null,
            Guid? teacherId = null,
            string? price = null,
            Guid? topicId = null,
            string? learnTime = null,
            CancellationToken cancellationToken = default);
    }
}