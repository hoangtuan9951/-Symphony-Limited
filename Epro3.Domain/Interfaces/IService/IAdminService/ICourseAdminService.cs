using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface ICourseAdminService
    {
        Task<IEnumerable<CourseAdminDTO>> GetAll();
        Task<CourseDetailAdminDTO> GetDetail(int id);
        Task Create(CreateCourseDTO createCourseDTO);
        Task Update(int id, UpdateCourseDTO updateCourseDTO);
        Task Delete(int id);
    }
}
