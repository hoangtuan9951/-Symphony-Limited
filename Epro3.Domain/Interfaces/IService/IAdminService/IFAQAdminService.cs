using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.EntranceExamStudentResult;
using Epro3.Domain.DTOs.AdminDTOs.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IFAQAdminService
    {
        Task<IEnumerable<FAQAdminDTO>> GetAll();
        Task<FAQDetailAdminDTO> GetDetail(int id);
        Task Create(CreateFAQDTO dto);
        Task Update(int id, UpdateFAQDTO dto);
        Task Delete(int id);
    }
}
