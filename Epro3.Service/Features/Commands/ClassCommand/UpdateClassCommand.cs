using Epro3.Application.Features.Commands.AboutCommand;
using Epro3.Application.Helpers;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.ClassCommand
{
    public class UpdateClassCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime StartTime { get; set; }
        public class UpdateClassCommandHandler : IRequestHandler<UpdateClassCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public UpdateClassCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(UpdateClassCommand command, CancellationToken cancellationToken)
            {

                Class data = await _unitOfWork.Classes.GetById(command.Id);

                data.Name = command.Name;
                data.LastUpdatedDate = DateTime.Now;
                data.Amount = command.Amount;
                data.StartTime = command.StartTime;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
