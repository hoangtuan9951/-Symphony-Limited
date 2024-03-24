using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.EntranceExamStudentResultCommand
{
    public class DeleteEntranceExamStudentResultCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteEntranceExamStudentResultCommandHandler : IRequestHandler<DeleteEntranceExamStudentResultCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteEntranceExamStudentResultCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteEntranceExamStudentResultCommand command, CancellationToken cancellationToken)
            {
                EntranceExamStudentResult data = await _unitOfWork.EntranceExamStudentResults.GetById(command.Id);
                _unitOfWork.EntranceExamStudentResults.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
