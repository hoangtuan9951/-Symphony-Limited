using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.FAQ;
using Epro3.Domain.DTOs.AdminDTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IStudentAdminService
    {
        Task<IEnumerable<StudentAdminDTO>> GetAll();
        Task<StudentDetailAdminDTO> GetDetail(int id);
        Task Create(CreateStudentDTO dto);
        Task Update(int id, UpdateStudentDTO dto);
        Task Delete(int id);
    }
}
