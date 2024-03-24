using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epro3.Domain.Interfaces.IRepository.Epro3;

namespace Epro3.Domain.Interfaces.IRepository.Architecture
{
    public interface IUnitOfWork : IDisposable
    {
        IAboutRepository Abouts { get; }
        IAdminRepository Admins { get; }
        IClassRepository Classes { get; }
        IContactRepository Contacts { get; }
        ICourseModuleRepository CourseModules { get; }
        ICourseRepository Courses { get; }
        IEntranceExamRepository EntranceExams { get; }
        IEntranceExamStudentResultRepository EntranceExamStudentResults { get; }
        IFAQRepository FAQs { get; }
        IStudentRepository Students { get; }
        Task<int> Complete();
    }
}
