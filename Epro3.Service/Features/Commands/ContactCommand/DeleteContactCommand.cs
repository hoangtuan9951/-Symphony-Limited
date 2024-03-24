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
    public class DeleteContactCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteContactCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteContactCommand command, CancellationToken cancellationToken)
            {
                Contact data = await _unitOfWork.Contacts.GetById(command.Id);
                _unitOfWork.Contacts.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
