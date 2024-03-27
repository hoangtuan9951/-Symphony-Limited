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
    public class UpdateCourseModuleCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public class UpdateCourseModuleCommandHandler : IRequestHandler<UpdateCourseModuleCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateCourseModuleCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateCourseModuleCommand command, CancellationToken cancellationToken)
            {

                CourseModule data = await _unitOfWork.CourseModules.GetById(command.Id);

                data.Name = command.Name;
                data.LastUpdatedDate = DateTime.Now;
                data.Amount = command.Amount;
                data.LastUpdatedDate = DateTime.Now;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
