using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.CourseQuery
{
    public class GetCourseByIdAdminQuery : IRequest<CourseDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetCourseByIdAdminQueryHandler : IRequestHandler<GetCourseByIdAdminQuery, CourseDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetCourseByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<CourseDetailAdminDTO> Handle(GetCourseByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<CourseDetailAdminDTO>(await _unitOfWork.Courses.GetById(command.Id));
            }
        }
    }

    public class GetCourseByIdClientQuery : IRequest<CourseDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetCourseByIdClientQueryHandler : IRequestHandler<GetCourseByIdClientQuery, CourseDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetCourseByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<CourseDetailClientDTO> Handle(GetCourseByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<CourseDetailClientDTO>(await _unitOfWork.Courses.GetById(command.Id));
            }
        }
    }
}
