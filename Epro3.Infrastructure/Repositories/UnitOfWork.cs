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
        public IEntrenceExamRepository EntrenceExam { get; private set; }
        public IFaqRepository Faq { get; private set; }
        public IAboutRepository About { get; private set; }
        public IUsercontactRepository Usercontact { get; private set; }

        public UnitOfWork(ApplicationDatabaseContext context,
                          ICourseRepository courseRepository, IEntrenceExamRepository entrenceExamRepository,
                          IFaqRepository faqRepository,
                          IAboutRepository aboutRepository,
                          IUsercontactRepository usercontactRepository)
        {
            _context = context;
            Courses = courseRepository;
            EntrenceExam = entrenceExamRepository;
            Faq = faqRepository;
            About = aboutRepository;
            Usercontact = usercontactRepository;
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
