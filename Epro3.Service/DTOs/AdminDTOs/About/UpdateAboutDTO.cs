using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.About
{
    public class UpdateAboutDTO
    {
        public string Description { get; set; } = string.Empty;
        public required IFormFile BackgroundImage { get; set; }
    }
}
