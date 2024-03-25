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
    public class GetLatestEntranceExamClientQuery : IRequest<EntranceExamClientDTO>
    {
        public int Id { get; set; }
        public class GetLatestEntranceExamQueryHandler : IRequestHandler<GetLatestEntranceExamClientQuery, EntranceExamClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetLatestEntranceExamQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamClientDTO> Handle(GetLatestEntranceExamClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamClientDTO>(await _unitOfWork.EntranceExams.GetById(command.Id));
            }
        }
    }
}
