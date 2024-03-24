using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.AboutCommand
{
    public class DeleteAboutCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteAboutCommandHandler : IRequestHandler<DeleteAboutCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteAboutCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteAboutCommand command, CancellationToken cancellationToken)
            {

                About data = await _unitOfWork.Abouts.GetById(command.Id);
                _unitOfWork.Abouts.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
