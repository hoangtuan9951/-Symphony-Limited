using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.Class
{
    public class ClassDetailAdminDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Course { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
