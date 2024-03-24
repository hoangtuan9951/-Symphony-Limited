using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.EntranceExam;
using Epro3.Domain.DTOs.AdminDTOs.EntranceExamStudentResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IEntranceExamStudentResultAdminService
    {
        Task<IEnumerable<EntranceExamStudentResultAdminDTO>> GetAll();
        Task<EntranceExamStudentResultDetailAdminDTO> GetDetail(int id);
        Task Create(CreateEntranceExamStudentResultDTO dto);
        Task Update(int id, UpdateEntranceExamStudentResultDTO dto);
        Task Delete(int id);
    }
}
