using Epro3.Domain.DTOs.AdminDTOs.Class;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.CourseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface ICourseModuleAdminService
    {
        Task<IEnumerable<CourseModuleAdminDTO>> GetAll();
        Task<CourseModuleDetailAdminDTO> GetDetail(int id);
        Task Create(CreateCourseModuleDTO dto);
        Task Update(int id, UpdateCourseModuleDTO dto);
        Task Delete(int id);
    }
}
