using AutoMapper;
using Epro3.Application.Helpers;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Infrastructure.DBContext;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.InfoCommand
{
    public class CreateUsercontactCommand : IRequest<Unit>
    {
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required string Message { get; set; }
  
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }

        public class CreateUsercontactCommandHandler : IRequestHandler<CreateUsercontactCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IWebHostEnvironment _env;
            public CreateUsercontactCommandHandler(IUnitOfWork unitOfWork,
                                      IMapper mapper,
                                      IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
                _env = env;
            }

            public async Task<Unit> Handle(CreateUsercontactCommand command, CancellationToken cancellationToken)
            {
            
                Usercontact userContact = new Usercontact
                {
                    Name = command.Name,
                    Email = command.Email,
                    PhoneNumber = command.PhoneNumber,
                    Message = command.Message,
                };
                _unitOfWork.Usercontact.Create(userContact);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
