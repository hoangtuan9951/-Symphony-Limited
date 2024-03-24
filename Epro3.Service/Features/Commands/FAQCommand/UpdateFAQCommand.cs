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
    public class UpdateFAQCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool Active { get; set; }
        public class UpdateFAQCommandHandler : IRequestHandler<UpdateFAQCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateFAQCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateFAQCommand command, CancellationToken cancellationToken)
            {
                FAQ data = await _unitOfWork.FAQs.GetById(command.Id);
                data.Question = command.Question;
                data.Answer = command.Answer;
                data.Active = command.Active;
                data.LastUpdatedDate = DateTime.Now;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
