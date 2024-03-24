using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.EntranceExamCommand
{
    public class UpdateEntranceExamCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime StartTime { get; set; }
        public class UpdateEntranceExamCommandHandler : IRequestHandler<UpdateEntranceExamCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateEntranceExamCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateEntranceExamCommand command, CancellationToken cancellationToken)
            {

                EntranceExam data = await _unitOfWork.EntranceExams.GetById(command.Id);
                data.Name = command.Name;
                data.StartTime = command.StartTime;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
