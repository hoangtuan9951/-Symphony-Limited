using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.CourseModuleCommand
{
    public class CreateCourseModuleCommand : IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }
        public int CourseId { get; set; }

        public class CreateCourseModuleCommandHandler : IRequestHandler<CreateCourseModuleCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateCourseModuleCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateCourseModuleCommand command, CancellationToken cancellationToken)
            {
                CourseModule data = new CourseModule
                {
                    Name = command.Name,
                    Amount = command.Amount,
                    CourseId = command.CourseId,
                    LastUpdatedDate = DateTime.Now
                };
                _unitOfWork.CourseModules.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
