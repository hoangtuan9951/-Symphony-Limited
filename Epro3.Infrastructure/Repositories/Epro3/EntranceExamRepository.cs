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
    public class EntranceExamRepository : GenericRepository<EntranceExam>, IEntranceExamRepository
    {
        public EntranceExamRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<EntranceExam> GetLastOverEntranceExamDetail()
        {
            var data = await _context.Set<EntranceExam>().OrderByDescending(e => e.StartTime).ToListAsync();
            var data2 = await _context.Set<EntranceExam>().Where(e => e.Id == data[1].Id).Include(e => e.EntranceExamStudentResults)!.ThenInclude(e => e.Student).FirstOrDefaultAsync();
            if (data2 == null)
            {
                throw new Exception("no data");
            }
            return data2;
        }

        public async Task<EntranceExam> GetLatestEntranceExamDetail()
        {
            var data = await _context.Set<EntranceExam>().OrderByDescending(e => e.StartTime).FirstOrDefaultAsync();
            if (data == null)
            {
                throw new Exception("no data");
            }
            return data;
        }
    }
}