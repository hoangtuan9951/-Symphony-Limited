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
        public int StudentId { get; set; }
        public int EntrenceExamId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }
    }
}