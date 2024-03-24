using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.Course
{
    public class CourseDetailClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public string BackGroundImage { get; set; } = string.Empty;
        public string CourseDetail { get; set; } = string.Empty;
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
    }
}
