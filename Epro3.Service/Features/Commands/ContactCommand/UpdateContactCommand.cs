using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.ContactCommand
{
    public class UpdateContactCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Hotline { get; set; } = string.Empty;
        public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateContactCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateContactCommand command, CancellationToken cancellationToken)
            {

                Contact data = await _unitOfWork.Contacts.GetById(command.Id);

                data.Address = command.Address;
                data.Hotline = command.Hotline;
                data.Email = command.Email;
                data.LastUpdatedDate = DateTime.Now;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
