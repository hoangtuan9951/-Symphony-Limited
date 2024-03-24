using Epro3.Domain.DTOs.AdminDTOs.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IAdminService
{
    public interface IAdminService
    {
        public Task<AdminAuthenDTO> AdminLogin(LoginFormDTO dto);
    }
}
