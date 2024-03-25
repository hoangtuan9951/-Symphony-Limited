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
    public class StudentIdRepository : IStudentIdRepository
    {
        private readonly ApplicationDatabaseContext _context;
        public StudentIdRepository(ApplicationDatabaseContext context) {
            _context = context;
        }
        public async Task<int> Create(StudentId entity)
        {
            _context.Set<StudentId>().Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }
    }
}
