using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.DTOs.ClientDTOs.Contact
{
    public class ContactDetailClientDTO
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Hotline { get; set; } = string.Empty;
    }
}
