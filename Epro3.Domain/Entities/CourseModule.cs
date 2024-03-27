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
        public string Name {  get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LastUpdatedDate { get; set;}
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
