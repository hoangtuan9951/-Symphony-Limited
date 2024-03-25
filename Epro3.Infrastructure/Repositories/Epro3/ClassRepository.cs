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
    public class ClassRepository : GenericRepository<Class>, IClassRepository
    {
        public ClassRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Class>> GetAllWithInclude()
        {
            return await _context.Set<Class>().Include(e => e.Course).ToListAsync();
        }

        public async Task<Class> GetDetailWithInclude(int id)
        {
            var data =  await _context.Set<Class>()
                                      .Where(e => e.Id == id)
                                      .Include(e => e.Course)
                                      .FirstOrDefaultAsync();
            if (data == null)
            {
                throw new Exception("data not found");
            }
            return data;
        }
    }
}
