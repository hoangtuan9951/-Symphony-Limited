using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BackGroundImage {  get; set; } = string.Empty;
        public decimal GradePass { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set;}
        public decimal Fee { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime FeeChagreDate { get; set; }
        public bool Active { get; set; }
        public ICollection<CourseModule>? CourseModules { get; set; }
        public ICollection<Class>? Classes { get; set; }
    }
}
