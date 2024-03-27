using Epro3.Application.Features.Commands.AboutCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.ClassCommand
{
    public class CreateClassCommand : IRequest<Unit>
    {
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime StartTime { get; set; }
        public int CourseId { get; set; }

        public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateClassCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateClassCommand command, CancellationToken cancellationToken)
            {
                Class data = new Class
                {
                    Name = command.Name,
                    Amount = command.Amount,
                    StartTime = command.StartTime,
                    LastUpdatedDate = DateTime.Now,
                    CourseId = command.CourseId,
                };
                _unitOfWork.Classes.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
