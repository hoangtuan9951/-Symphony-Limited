using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Email {  get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string Hotline {  get; set; } = string.Empty;
        public DateTime LastUpdatedDate { get; set;}
    }
}
