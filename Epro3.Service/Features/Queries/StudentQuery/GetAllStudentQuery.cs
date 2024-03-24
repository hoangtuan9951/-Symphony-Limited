using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Student;
using Epro3.Application.DTOs.ClientDTOs.Student;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.StudentQuery
{
    public class GetAllStudentAdminQuery : IRequest<IEnumerable<StudentAdminDTO>>
    {
        public class GetAllStudentAdminQueryHandler : IRequestHandler<GetAllStudentAdminQuery, IEnumerable<StudentAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllStudentAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<StudentAdminDTO>> Handle(GetAllStudentAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<StudentAdminDTO>>(await _unitOfWork.Students.GetAll());
            }
        }
    }

    public class GetAllStudentClientQuery : IRequest<IEnumerable<StudentClientDTO>>
    {
        public class GetAllStudentClientQueryHandler : IRequestHandler<GetAllStudentClientQuery, IEnumerable<StudentClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllStudentClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<StudentClientDTO>> Handle(GetAllStudentClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<StudentClientDTO>>(await _unitOfWork.Students.GetAll());
            }
        }
    }
}
