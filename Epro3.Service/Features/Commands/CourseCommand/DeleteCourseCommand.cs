using AutoMapper;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.CourseCommand
{
    public class DeleteCourseCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            public DeleteCourseCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<Unit> Handle(DeleteCourseCommand command, CancellationToken cancellationToken)
            {

                Course data = await _unitOfWork.Courses.GetById(command.Id);
                _unitOfWork.Courses.Delete(data);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
