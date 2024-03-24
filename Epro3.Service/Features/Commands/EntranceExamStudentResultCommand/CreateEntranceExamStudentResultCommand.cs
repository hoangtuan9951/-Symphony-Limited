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

namespace Epro3.Application.Features.Commands.EntranceExamStudentResultCommand
{
    public class CreateEntranceExamStudentResultCommand : IRequest<Unit>
    {
        public int StudentId { get; set; }
        public int EntrenceExamId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }

        public class CreateEntranceExamStudentResultCommandHandler : IRequestHandler<CreateEntranceExamStudentResultCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateEntranceExamStudentResultCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateEntranceExamStudentResultCommand command, CancellationToken cancellationToken)
            {
                EntranceExamStudentResult data = new EntranceExamStudentResult
                {
                    StudentId = command.StudentId,
                    CourseId = command.CourseId,
                    Grade = command.Grade,
                    EntrenceExamId = command.EntrenceExamId
                };
                _unitOfWork.EntranceExamStudentResults.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
