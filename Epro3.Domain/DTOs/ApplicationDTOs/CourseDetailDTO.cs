using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.DTOs.ApplicationDTOs
{
    public class CourseDetailDTO
    {
        public int Id { get; set; }
        public string BackgroundImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
