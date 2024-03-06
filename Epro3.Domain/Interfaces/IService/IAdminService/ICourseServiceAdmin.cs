using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.CourseDetail;
using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface ICourseServiceAdmin
    {
        Task GetAll();
        Task<GetCourseDetailDTO> GetDetail(int id);
        Task Create(CreateCourseDTO createCourseDTO, CreateCourseDetailDTO createCourseDetailDTO);
        Task Update(int id, UpdateCourseDTO updateCourseDTO);
        Task Delete(int id);
    }
}
