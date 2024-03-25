using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.Repositories.Epro3;
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
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IStudentIdRepository _studentIdRepository;
            public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IStudentIdRepository studentIdRepository)
            {
                _unitOfWork = unitOfWork;
                _studentIdRepository = studentIdRepository;
            }

            public async Task<Unit> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
            {
                StudentId studentId = new StudentId();
                Student data = new Student
                {
                    Name = command.Name,
                    Email = command.Email,
                    RollNumber = "C2009L" + await _studentIdRepository.Create(studentId),
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
