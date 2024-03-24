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
    public class GetAllFAQAdminQuery : IRequest<IEnumerable<FAQAdminDTO>>
    {
        public class GetAllFAQAdminQueryHandler : IRequestHandler<GetAllFAQAdminQuery, IEnumerable<FAQAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllFAQAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<FAQAdminDTO>> Handle(GetAllFAQAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<FAQAdminDTO>>(await _unitOfWork.FAQs.GetAll());
            }
        }
    }

    public class GetAllFAQClientQuery : IRequest<IEnumerable<FAQClientDTO>>
    {
        public class GetAllFAQClientQueryHandler : IRequestHandler<GetAllFAQClientQuery, IEnumerable<FAQClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllFAQClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<FAQClientDTO>> Handle(GetAllFAQClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<FAQClientDTO>>(await _unitOfWork.FAQs.GetAll());
            }
        }
    }
}
