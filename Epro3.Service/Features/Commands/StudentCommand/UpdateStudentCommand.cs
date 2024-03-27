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
    public class UpdateStudentCommand : IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;
        public string RollNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateStudentCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
            {

                Student data = await _unitOfWork.Students.GetStudentByRollNumber(command.RollNumber);

                data.Name = command.Name;
                data.Email = command.Email;
                data.LastUpdatedDate = DateTime.Now;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
