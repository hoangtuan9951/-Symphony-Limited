using Epro3.Domain.DTOs.AdminDTOs.Class;
using Epro3.Domain.DTOs.AdminDTOs.Contact;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IContactAdminService
    {
        Task<IEnumerable<ContactAdminDTO>> GetAll();
        Task<ContactDetailAdminDTO> GetDetail(int id);
        Task Create(CreateContactDTO dto);
        Task Update(int id, UpdateContactDTO dto);
        Task Delete(int id);
    }
}
