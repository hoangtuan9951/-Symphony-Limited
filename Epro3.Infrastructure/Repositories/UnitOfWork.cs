using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using Epro3.Infrastructure.Repositories.Epro3;
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
        public IAboutRepository Abouts { get; private set; }
        public IAdminRepository Admins { get; private set; }
        public IClassRepository Classes { get; private set; }
        public IContactRepository Contacts { get; private set; }
        public ICourseModuleRepository CourseModules { get; private set; }
        public ICourseRepository Courses { get; private set; }
        public IEntranceExamRepository EntranceExams { get; private set; }
        public IEntranceExamStudentResultRepository EntranceExamStudentResults { get; private set; }
        public IFAQRepository FAQs { get; private set; }
        public IStudentRepository Students { get; private set; }
        public UnitOfWork(ApplicationDatabaseContext context)
        {
            _context = context;
            Abouts = new AboutRepository(_context);
            Admins = new AdminRepository(_context);
            Classes = new ClassRepository(_context);
            Contacts = new ContactRepository(_context);
            CourseModules = new CourseModuleRepository(_context);
            Courses = new CourseRepository(_context);
            EntranceExams = new EntranceExamRepository(_context);
            EntranceExamStudentResults = new EntranceExamStudentResultRepository(_context);
            FAQs = new FAQRepository(_context);
            Students = new StudentRepository(_context);
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
