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
    public class GetStudentByIdAdminQuery : IRequest<StudentDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetStudentByIdAdminQueryHandler : IRequestHandler<GetStudentByIdAdminQuery, StudentDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetStudentByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<StudentDetailAdminDTO> Handle(GetStudentByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<StudentDetailAdminDTO>(await _unitOfWork.Students.GetById(command.Id));
            }
        }
    }

    public class GetStudentByIdClientQuery : IRequest<StudentDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetStudentByIdClientQueryHandler : IRequestHandler<GetStudentByIdClientQuery, StudentDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetStudentByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<StudentDetailClientDTO> Handle(GetStudentByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<StudentDetailClientDTO>(await _unitOfWork.Students.GetById(command.Id));
            }
        }
    }
}
