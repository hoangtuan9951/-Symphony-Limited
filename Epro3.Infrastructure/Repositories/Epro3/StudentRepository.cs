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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task DeleteStudent(string studentRollNumber)
        {
            var data = await _context.Set<Student>().Where(e => e.RollNumber == studentRollNumber).FirstOrDefaultAsync();
            if (data == null)
            {
                throw new Exception("student not found");
            }
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
