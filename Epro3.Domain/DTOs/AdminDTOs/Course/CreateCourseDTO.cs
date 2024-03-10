using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.DTOs.AdminDTOs.Course
{
    public class CreateCourseDTO
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public required string Description { get; set; }
        public required string CourseDetail { get; set; }
        public required IFormFile Thumbnail { get; set; }
        public required IFormFile BackGroundImage { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public bool Active { get; set; }
    }
}
