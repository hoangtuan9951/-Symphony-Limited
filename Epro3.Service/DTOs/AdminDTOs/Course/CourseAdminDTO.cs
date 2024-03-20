using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.Course
{
    public class CourseAdminDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public string Thumbnail { get; set; } = string.Empty;
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public bool Active { get; set; }
    }
}
