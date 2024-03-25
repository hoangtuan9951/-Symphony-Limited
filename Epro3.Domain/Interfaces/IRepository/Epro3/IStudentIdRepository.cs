using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IRepository.Epro3
{
    public interface IStudentIdRepository
    {
        Task<int> Create(StudentId entity);
    }
}
