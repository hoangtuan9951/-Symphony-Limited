using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.StudentCommand
{
    public class DeleteStudentCommand : IRequest<Unit>
    {
        public required string StudentRollNumber { get; set; }
        public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteStudentCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
            {
                await _unitOfWork.Students.DeleteStudent(command.StudentRollNumber);
                return Unit.Value;
            }
        }
    }
}
