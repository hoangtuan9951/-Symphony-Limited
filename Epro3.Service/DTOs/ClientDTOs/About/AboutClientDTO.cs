using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.About
{
    public class AboutClientDTO
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string BackgroundImage { get; set; } = string.Empty;
    }
}
