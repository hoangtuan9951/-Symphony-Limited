using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Course>> GetSixLatestCourse()
        {
            return await _context.Set<Course>()
                                 .OrderByDescending(e => e.CreatedDate)
                                 .Take(6)
                                 .ToListAsync();
        }
    }
}