using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.Class
{
    public class ClassAdminDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
    }
}
