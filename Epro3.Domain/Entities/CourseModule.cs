using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class CourseModule
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ModuleName {  get; set; } = string.Empty;
        public int Amount { get; set; } = 0;
        public string Active { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set;}
    }
}
