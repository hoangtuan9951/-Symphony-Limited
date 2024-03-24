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

namespace Epro3.Application.Features.Commands.EntranceExamCommand
{
    public class CreateEntranceExamCommand : IRequest<Unit>
    {
        public int Name { get; set; }
        public DateTime StartTime { get; set; }

        public class CreateEntranceExamCommandHandler : IRequestHandler<CreateEntranceExamCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateEntranceExamCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateEntranceExamCommand command, CancellationToken cancellationToken)
            {
                EntranceExam data = new EntranceExam
                {
                    Name = command.Name,
                    StartTime = command.StartTime
                };

                _unitOfWork.EntranceExams.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
