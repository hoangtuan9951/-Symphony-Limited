using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.FAQ;
using Epro3.Application.DTOs.ClientDTOs.FAQ;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.FAQQuery
{
    public class GetFAQByIdAdminQuery : IRequest<FAQDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetFAQByIdAdminQueryHandler : IRequestHandler<GetFAQByIdAdminQuery, FAQDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetFAQByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<FAQDetailAdminDTO> Handle(GetFAQByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<FAQDetailAdminDTO>(await _unitOfWork.FAQs.GetById(command.Id));
            }
        }
    }

    public class GetFAQByIdClientQuery : IRequest<FAQDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetFAQByIdClientQueryHandler : IRequestHandler<GetFAQByIdClientQuery, FAQDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetFAQByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<FAQDetailClientDTO> Handle(GetFAQByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<FAQDetailClientDTO>(await _unitOfWork.FAQs.GetById(command.Id));
            }
        }
    }
}
