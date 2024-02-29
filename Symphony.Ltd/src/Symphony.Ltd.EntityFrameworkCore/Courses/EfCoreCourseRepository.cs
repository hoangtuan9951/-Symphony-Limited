using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Symphony.Ltd.EntityFrameworkCore;

namespace Symphony.Ltd.Courses
{
    public class EfCoreCourseRepository : EfCoreRepository<LtdDbContext, Course, Guid>, ICourseRepository
    {
        public EfCoreCourseRepository(IDbContextProvider<LtdDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        public virtual async Task<List<Course>> GetListAsync(
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
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetQueryableAsync()), filterText, title, description, teacherId, price, topicId, learnTime);
            query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ? CourseConsts.GetDefaultSorting(false) : sorting);
            return await query.PageBy(skipCount, maxResultCount).ToListAsync(cancellationToken);
        }

        public virtual async Task<long> GetCountAsync(
            string? filterText = null,
            string? title = null,
            string? description = null,
            Guid? teacherId = null,
            string? price = null,
            Guid? topicId = null,
            string? learnTime = null,
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetDbSetAsync()), filterText, title, description, teacherId, price, topicId, learnTime);
            return await query.LongCountAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual IQueryable<Course> ApplyFilter(
            IQueryable<Course> query,
            string? filterText = null,
            string? title = null,
            string? description = null,
            Guid? teacherId = null,
            string? price = null,
            Guid? topicId = null,
            string? learnTime = null)
        {
            return query
                    .WhereIf(!string.IsNullOrWhiteSpace(filterText), e => e.Title!.Contains(filterText!) || e.Description!.Contains(filterText!) || e.Price!.Contains(filterText!) || e.LearnTime!.Contains(filterText!))
                    .WhereIf(!string.IsNullOrWhiteSpace(title), e => e.Title.Contains(title))
                    .WhereIf(!string.IsNullOrWhiteSpace(description), e => e.Description.Contains(description))
                    .WhereIf(teacherId.HasValue, e => e.TeacherId == teacherId)
                    .WhereIf(!string.IsNullOrWhiteSpace(price), e => e.Price.Contains(price))
                    .WhereIf(topicId.HasValue, e => e.TopicId == topicId)
                    .WhereIf(!string.IsNullOrWhiteSpace(learnTime), e => e.LearnTime.Contains(learnTime));
        }
    }
}