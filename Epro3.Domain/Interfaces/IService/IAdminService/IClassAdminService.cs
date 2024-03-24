using Epro3.Domain.DTOs.AdminDTOs.Class;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IClassAdminService
    {
        Task<IEnumerable<ClassAdminDTO>> GetAll();
        Task<ClassDetailAdminDTO> GetDetail(int id);
        Task Create(CreateClassDTO dto);
        Task Update(int id, UpdateClassDTO dto);
        Task Delete(int id);
    }
}
