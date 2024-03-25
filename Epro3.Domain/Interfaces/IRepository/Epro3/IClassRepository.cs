using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IRepository.Epro3
{
    public interface IClassRepository : IGenericRepository<Class>
    {
        Task<IEnumerable<Class>> GetAllWithInclude();
        Task<Class> GetDetailWithInclude(int id);
    }
}
