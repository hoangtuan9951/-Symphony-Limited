using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        Task<int> Complete();
    }
}
