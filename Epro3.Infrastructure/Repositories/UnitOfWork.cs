using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IRepository.Epro3;
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
        public UnitOfWork(ApplicationDatabaseContext context,
                          IAboutRepository aboutRepository,
                          IAdminRepository adminRepository,
                          IClassRepository classRepository,
                          IContactRepository contactRepository,
                          ICourseModuleRepository courseModuleRepository,
                          ICourseRepository courseRepository,
                          IEntranceExamRepository entranceExamRepository,
                          IEntranceExamStudentResultRepository entranceExamStudentResultRepository,
                          IFAQRepository fAQRepository,
                          IStudentRepository studentRepository)
        {
            _context = context;
            Abouts = aboutRepository;
            Admins = adminRepository;
            Classes = classRepository;
            Contacts = contactRepository;
            CourseModules = courseModuleRepository;
            Courses = courseRepository;
            EntranceExams = entranceExamRepository;
            EntranceExamStudentResults = entranceExamStudentResultRepository;
            FAQs = fAQRepository;
            Students = studentRepository;
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
