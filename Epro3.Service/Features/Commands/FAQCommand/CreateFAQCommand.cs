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

namespace Epro3.Application.Features.Commands.FAQCommand
{
    public class CreateFAQCommand : IRequest<Unit>
    {
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public bool Active { get; set; }

        public class CreateFAQCommandHandler : IRequestHandler<CreateFAQCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public CreateFAQCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Unit> Handle(CreateFAQCommand command, CancellationToken cancellationToken)
            {
                FAQ data = new FAQ
                {
                    Question = command.Question,
                    Answer = command.Answer,
                    Active = command.Active,
                    LastUpdatedDate = DateTime.Now
                };
                _unitOfWork.FAQs.Create(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
