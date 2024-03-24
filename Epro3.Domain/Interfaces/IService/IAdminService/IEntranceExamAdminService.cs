using Epro3.Domain.DTOs.AdminDTOs.Class;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.EntranceExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IEntranceExamAdminService
    {
        Task<IEnumerable<EntranceExamAdminDTO>> GetAll();
        Task<EntranceExamDetailAdminDTO> GetDetail(int id);
        Task Create(CreateEntranceExamDTO dto);
        Task Update(int id, UpdateEntranceExamDTO dto);
        Task Delete(int id);
    }
}
