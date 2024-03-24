using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.AdminDTOs.Admin
{
    public class AdminAuthenDTO
    {
        public int AdminId { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
