using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.CourseModuleCommand
{
    public class DeleteCourseModuleCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteCourseModuleCommandHandler : IRequestHandler<DeleteCourseModuleCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteCourseModuleCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteCourseModuleCommand command, CancellationToken cancellationToken)
            {
                CourseModule data = await _unitOfWork.CourseModules.GetById(command.Id);
                _unitOfWork.CourseModules.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
