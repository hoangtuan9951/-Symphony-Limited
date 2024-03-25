using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.EntranceExam
{
    public class EntranceExamDetailClientDTO
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime StartTime { get; set; }
        public List<EntranceExamDetailDataDTO>? DTO { get; set; }
    }
}
