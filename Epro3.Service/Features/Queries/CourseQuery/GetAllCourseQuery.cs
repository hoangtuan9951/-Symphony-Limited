using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs;
using Epro3.Application.DTOs.ClientDTOs.Course;
using Epro3.Application.Features.Commands;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.CourseQuery
{
    public class GetAllCourseAdminQuery : IRequest<IEnumerable<CourseAdminDTO>>
    {
        public class GetAllCourseAdminQueryHandler : IRequestHandler<GetAllCourseAdminQuery, IEnumerable<CourseAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllCourseAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<CourseAdminDTO>> Handle(GetAllCourseAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<CourseAdminDTO>>(await _unitOfWork.Courses.GetAll());
            }
        }
    }

    public class GetAllCourseClientQuery : IRequest<IEnumerable<CourseClientDTO>>
    {
        public class GetAllCourseClientQueryHandler : IRequestHandler<GetAllCourseClientQuery, IEnumerable<CourseClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllCourseClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<CourseClientDTO>> Handle(GetAllCourseClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<CourseClientDTO>>(await _unitOfWork.Courses.GetAll());
            }
        }
    }
}
