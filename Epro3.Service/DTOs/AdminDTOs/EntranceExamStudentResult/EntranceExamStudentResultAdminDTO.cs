using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.EntranceExamStudentResult
{
    public class EntranceExamStudentResultAdminDTO
    {
        public int Id { get; set; }
        public string Student { get; set; } = string.Empty;
        public string EntrenceExam { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public int Grade { get; set; }
    }
}
