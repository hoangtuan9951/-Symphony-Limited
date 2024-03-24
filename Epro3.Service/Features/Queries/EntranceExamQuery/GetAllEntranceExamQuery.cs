using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.EntranceExam;
using Epro3.Application.DTOs.ClientDTOs.EntranceExam;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.EntranceExamQuery
{
    public class GetAllEntranceExamAdminQuery : IRequest<IEnumerable<EntranceExamAdminDTO>>
    {
        public class GetAllEntranceExamAdminQueryHandler : IRequestHandler<GetAllEntranceExamAdminQuery, IEnumerable<EntranceExamAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllEntranceExamAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<EntranceExamAdminDTO>> Handle(GetAllEntranceExamAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<EntranceExamAdminDTO>>(await _unitOfWork.EntranceExams.GetAll());
            }
        }
    }

    public class GetAllEntranceExamClientQuery : IRequest<IEnumerable<EntranceExamClientDTO>>
    {
        public class GetAllEntranceExamClientQueryHandler : IRequestHandler<GetAllEntranceExamClientQuery, IEnumerable<EntranceExamClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllEntranceExamClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<EntranceExamClientDTO>> Handle(GetAllEntranceExamClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<EntranceExamClientDTO>>(await _unitOfWork.EntranceExams.GetAll());
            }
        }
    }
}
