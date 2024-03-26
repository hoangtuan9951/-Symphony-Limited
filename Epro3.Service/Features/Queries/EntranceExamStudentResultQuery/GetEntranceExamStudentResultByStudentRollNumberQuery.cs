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
 
    public class GetEntranceExamStudentResultByStudentRollNumberClientQuery : IRequest<EntranceExamStudentResultDetailClientDTO>
    {
        public required string StudentRollNumber { get; set; }
        public class GetEntranceExamStudentResultByStudentRollNumberClientQueryHandler : IRequestHandler<GetEntranceExamStudentResultByStudentRollNumberClientQuery, EntranceExamStudentResultDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetEntranceExamStudentResultByStudentRollNumberClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamStudentResultDetailClientDTO> Handle(GetEntranceExamStudentResultByStudentRollNumberClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamStudentResultDetailClientDTO>(await _unitOfWork.EntranceExamStudentResults.GetDetailWithInclude(command.StudentRollNumber));
            }
        }
    }
}
