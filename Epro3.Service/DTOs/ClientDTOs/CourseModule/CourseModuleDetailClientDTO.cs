using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.CourseModule
{
    public class CourseModuleDetailClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
    }
}
