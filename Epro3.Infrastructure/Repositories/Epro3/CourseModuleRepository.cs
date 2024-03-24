using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories.Epro3
{
    public class CourseModuleRepository : GenericRepository<CourseModule>, ICourseModuleRepository
    {
        public CourseModuleRepository(ApplicationDatabaseContext context) : base(context)
        {
        }
    }
}
