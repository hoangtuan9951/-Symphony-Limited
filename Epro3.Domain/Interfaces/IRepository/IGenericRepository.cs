using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Delete(T entity);
    }
}
