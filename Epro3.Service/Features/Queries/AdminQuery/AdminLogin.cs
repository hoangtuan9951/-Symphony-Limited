using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.About;
using Epro3.Application.DTOs.AdminDTOs.Admin;
using Epro3.Application.Features.Queries.AboutQuery;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.AdminQuery
{
    public class AdminLogin : IRequest<AdminAuthenDTO>
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public class AdminLoginHandler : IRequestHandler<AdminLogin, AdminAuthenDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            public AdminLoginHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<AdminAuthenDTO> Handle(AdminLogin command, CancellationToken cancellationToken)
            {
                return new AdminAuthenDTO
                {
                    AdminId = await _unitOfWork.Admins.Login(command.UserName, command.Password),
                    Role = "Admin"
                };
            }
        }
    }
}
