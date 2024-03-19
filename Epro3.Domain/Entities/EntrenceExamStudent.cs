using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class EntrenceExamStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int EntrenceExamId { get; set; }
        public int Grade { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set;}
    }
}
