using Epro3.Domain.DTOs.AdminDTOs.About;
using Epro3.Domain.DTOs.AdminDTOs.Class;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IAboutAdminService
    {
        Task<IEnumerable<AboutAdminDTO>> GetAll();
        Task Create(ClassDetailAdminDTO dto);
        Task Update(int id, UpdateAboutDTO dto);
        Task Delete(int id);
    }
}
