using Epro3.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.Course
{
    public class CourseClientDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
    }
}
