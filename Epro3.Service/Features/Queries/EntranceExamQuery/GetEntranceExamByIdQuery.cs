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
    public class GetEntranceExamByIdAdminQuery : IRequest<EntranceExamDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetEntranceExamByIdAdminQueryHandler : IRequestHandler<GetEntranceExamByIdAdminQuery, EntranceExamDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetEntranceExamByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamDetailAdminDTO> Handle(GetEntranceExamByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamDetailAdminDTO>(await _unitOfWork.EntranceExams.GetById(command.Id));
            }
        }
    }

    public class GetEntranceExamByIdClientQuery : IRequest<EntranceExamDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetEntranceExamByIdClientQueryHandler : IRequestHandler<GetEntranceExamByIdClientQuery, EntranceExamDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetEntranceExamByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<EntranceExamDetailClientDTO> Handle(GetEntranceExamByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<EntranceExamDetailClientDTO>(await _unitOfWork.EntranceExams.GetById(command.Id));
            }
        }
    }
}
