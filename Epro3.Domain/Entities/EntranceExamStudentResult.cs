using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class EntranceExamStudentResult
    {
        public int Id { get; set; }
        public string StudentRollNumber { get; set; } = string.Empty;
        public int EntranceExamId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
        public EntranceExam? EntranceExam { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
