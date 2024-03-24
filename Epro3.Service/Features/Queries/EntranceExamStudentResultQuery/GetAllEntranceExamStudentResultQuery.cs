using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.EntranceExam;
using Epro3.Application.DTOs.AdminDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.ClientDTOs.EntranceExam;
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
    public class GetAllEntranceExamStudentResultAdminQuery : IRequest<IEnumerable<EntranceExamStudentResultAdminDTO>>
    {
        public class GetAllEntranceExamStudentResultAdminQueryHandler : IRequestHandler<GetAllEntranceExamStudentResultAdminQuery, IEnumerable<EntranceExamStudentResultAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllEntranceExamStudentResultAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<EntranceExamStudentResultAdminDTO>> Handle(GetAllEntranceExamStudentResultAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<EntranceExamStudentResultAdminDTO>>(await _unitOfWork.EntranceExams.GetAll());
            }
        }
    }

    public class GetAllEntranceExamStudentResultClientQuery : IRequest<IEnumerable<EntranceExamStudentResultClientDTO>>
    {
        public class GetAllEntranceExamStudentResultClientQueryHandler : IRequestHandler<GetAllEntranceExamStudentResultClientQuery, IEnumerable<EntranceExamStudentResultClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllEntranceExamStudentResultClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<EntranceExamStudentResultClientDTO>> Handle(GetAllEntranceExamStudentResultClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<EntranceExamStudentResultClientDTO>>(await _unitOfWork.EntranceExamStudentResults.GetAll());
            }
        }
    }
}
