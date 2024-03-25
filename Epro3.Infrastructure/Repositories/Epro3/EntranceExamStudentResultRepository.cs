using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories.Epro3
{
    public class EntranceExamStudentResultRepository : GenericRepository<EntranceExamStudentResult>, IEntranceExamStudentResultRepository
    {
        public EntranceExamStudentResultRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<EntranceExamStudentResult>> GetAllWithInclude()
        {
            return await _context.Set<EntranceExamStudentResult>()
                                 .Include(e => e.Student)
                                 .Include(e => e.Course)
                                 .Include(e => e.EntranceExam)
                                 .ToListAsync();
        }

        public async Task<EntranceExamStudentResult> GetDetailWithInclude(string studentRollNumber)
        {
            var data = await _context.Set<EntranceExamStudentResult>()
                                     .Where(e => e.StudentRollNumber == studentRollNumber)
                                     .Include(e => e.Course)
                                     .Include(e => e.Student)
                                     .Include(e => e.EntranceExam)
                                     .FirstOrDefaultAsync();
            if (data == null)
            {
                throw new Exception("no data found");
            }
            return data;
        }
    }
}
