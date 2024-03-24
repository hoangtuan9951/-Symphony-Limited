using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.ContactCommand
{
    public class CreateContactCommand : IRequest<Unit>
    {
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Hotline { get; set; } = string.Empty;

        public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateContactCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateContactCommand command, CancellationToken cancellationToken)
            {
                Contact data = new Contact
                {
                    Address = command.Address,
                    Email = command.Email,
                    Hotline = command.Hotline,
                    LastUpdatedDate = DateTime.Now
                };

                _unitOfWork.Contacts.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
