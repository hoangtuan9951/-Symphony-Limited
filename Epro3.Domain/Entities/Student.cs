using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class Student
    {
        public string RollNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set;}
        public EntranceExamStudentResult? EntranceExamStudentResult { get; set; }
    }
}
