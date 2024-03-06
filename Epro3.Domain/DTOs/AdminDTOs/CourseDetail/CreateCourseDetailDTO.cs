using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.DTOs.AdminDTOs.CourseDetail
{
    public class CreateCourseDetailDTO
    {
        public int CourseId { get; set; }
        public string BackgroundImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
