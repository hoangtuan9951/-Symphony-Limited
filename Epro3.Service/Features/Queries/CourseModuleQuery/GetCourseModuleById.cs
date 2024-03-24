using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.CourseModule;
using Epro3.Application.DTOs.ClientDTOs.CourseModule;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.CourseModuleQuery
{
    public class GetCourseModuleByIdAdminQuery : IRequest<CourseModuleDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetCourseModuleByIdAdminQueryHandler : IRequestHandler<GetCourseModuleByIdAdminQuery, CourseModuleDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetCourseModuleByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<CourseModuleDetailAdminDTO> Handle(GetCourseModuleByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<CourseModuleDetailAdminDTO>(await _unitOfWork.CourseModules.GetById(command.Id));
            }
        }
    }

    public class GetCourseModuleModuleByIdClientQuery : IRequest<CourseModuleDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetCourseModuleModuleByIdClientQueryHandler : IRequestHandler<GetCourseModuleModuleByIdClientQuery, CourseModuleDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetCourseModuleModuleByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<CourseModuleDetailClientDTO> Handle(GetCourseModuleModuleByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<CourseModuleDetailClientDTO>(await _unitOfWork.CourseModules.GetById(command.Id));
            }
        }
    }
}
