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
    public class GetAllCourseModuleAdminQuery : IRequest<IEnumerable<CourseModuleAdminDTO>>
    {
        public class GetAllCourseModuleAdminQueryHandler : IRequestHandler<GetAllCourseModuleAdminQuery, IEnumerable<CourseModuleAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllCourseModuleAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<CourseModuleAdminDTO>> Handle(GetAllCourseModuleAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<CourseModuleAdminDTO>>(await _unitOfWork.CourseModules.GetAll());
            }
        }
    }

    public class GetAllCourseModuleClientQuery : IRequest<IEnumerable<CourseModuleClientDTO>>
    {
        public class GetAllCourseModuleClientQueryHandler : IRequestHandler<GetAllCourseModuleClientQuery, IEnumerable<CourseModuleClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllCourseModuleClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<CourseModuleClientDTO>> Handle(GetAllCourseModuleClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<CourseModuleClientDTO>>(await _unitOfWork.CourseModules.GetAll());
            }
        }
    }
}
