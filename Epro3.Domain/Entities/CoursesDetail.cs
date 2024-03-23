using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class CourseDetail
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseSlug {  get; set; } = string.Empty;
        public string BackgroundImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DetailCourse { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set;}
    }
}
