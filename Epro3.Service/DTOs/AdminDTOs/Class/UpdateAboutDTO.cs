using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.Class
{
    public class UpdateClassDTO
    {
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime StartTime { get; set; }
    }
}
