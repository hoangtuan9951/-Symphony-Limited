using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.ClientDTOs.EntranceExamStudentResult;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.EntranceExamStudentResultQuery
{
    public class GetEntranceExamStudentResultByIdAdminQuery : IRequest<EntranceExamStudentResultDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetEntranceExamStudentResultByIdAdminQueryHandler : IRequestHandler<GetEntranceExamStudentResultByIdAdminQuery, EntranceExamStudentResultDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetEntranceExamStudentResultByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamStudentResultDetailAdminDTO> Handle(GetEntranceExamStudentResultByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamStudentResultDetailAdminDTO>(await _unitOfWork.EntranceExamStudentResults.GetById(command.Id));
            }
        }
    }

    public class GetEntranceExamStudentResultByIdClientQuery : IRequest<EntranceExamStudentResultDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetEntranceExamStudentResultByIdClientQueryHandler : IRequestHandler<GetEntranceExamStudentResultByIdClientQuery, EntranceExamStudentResultDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetEntranceExamStudentResultByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamStudentResultDetailClientDTO> Handle(GetEntranceExamStudentResultByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamStudentResultDetailClientDTO>(await _unitOfWork.EntranceExamStudentResults.GetById(command.Id));
            }
        }
    }
}
