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
    public class DeleteEntranceExamCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteEntranceExamCommandHandler : IRequestHandler<DeleteEntranceExamCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteEntranceExamCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteEntranceExamCommand command, CancellationToken cancellationToken)
            {
                EntranceExam data = await _unitOfWork.EntranceExams.GetById(command.Id);
                _unitOfWork.EntranceExams.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
