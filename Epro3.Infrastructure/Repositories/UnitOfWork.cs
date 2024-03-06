using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Infrastructure.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDatabaseContext _context;
        public ICourseRepository Courses { get; private set; }
        public ICourseDetailRepository CourseDetails { get; private set; }

        public UnitOfWork(ApplicationDatabaseContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            CourseDetails = new CourseDetailRepository(_context);
        }
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
