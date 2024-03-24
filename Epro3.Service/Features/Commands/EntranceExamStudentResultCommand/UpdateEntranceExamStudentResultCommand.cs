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
    public class UpdateEntranceExamStudentResultCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public class UpdateEntranceExamStudentResultCommandHandler : IRequestHandler<UpdateEntranceExamStudentResultCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateEntranceExamStudentResultCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateEntranceExamStudentResultCommand command, CancellationToken cancellationToken)
            {
                EntranceExamStudentResult data = await _unitOfWork.EntranceExamStudentResults.GetById(command.Id);
                data.Grade = command.Grade;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
