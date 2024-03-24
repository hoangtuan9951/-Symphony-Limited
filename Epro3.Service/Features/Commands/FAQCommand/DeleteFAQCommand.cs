using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.FAQCommand
{
    public class DeleteFAQCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteFAQCommandHandler : IRequestHandler<DeleteFAQCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteFAQCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteFAQCommand command, CancellationToken cancellationToken)
            {
                FAQ data = await _unitOfWork.FAQs.GetById(command.Id);
                _unitOfWork.FAQs.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
