using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class EntranceExam
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime StartTime { get; set; }
        public ICollection<EntranceExamStudentResult>? EntranceExamStudentResults { get; set; }
    }
}
