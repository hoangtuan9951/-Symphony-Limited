using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.DTOs.AdminDTOs.Course
{
    public class UpdateCourseDTO
    {
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public required IFormFile Image { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}
