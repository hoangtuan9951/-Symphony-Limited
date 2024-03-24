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

namespace Epro3.Application.Features.Commands.StudentCommand
{
    public class CreateStudentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RollNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
            {
                Student data = new Student
                {
                    Name = command.Name,
                    Email = command.Email,
                    RollNumber = command.RollNumber,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now
                };
                _unitOfWork.Students.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
