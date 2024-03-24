using AutoMapper;
using Epro3.Application.DTOs.ClientDTOs.Course;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.CourseQuery
{
    public class GetSixLatestCourseClientQuery : IRequest<IEnumerable<CourseClientDTO>>
    {
        public class GetSixLatestCourseQueryHandler : IRequestHandler<GetSixLatestCourseClientQuery, IEnumerable<CourseClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetSixLatestCourseQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<CourseClientDTO>> Handle(GetSixLatestCourseClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<CourseClientDTO>>(await _unitOfWork.Courses.GetSixLatestCourse());
            }
        }
    }
}
