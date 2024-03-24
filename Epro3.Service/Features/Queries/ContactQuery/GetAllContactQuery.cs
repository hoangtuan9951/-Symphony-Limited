using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Contact;
using Epro3.Application.DTOs.ClientDTOs.Contact;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.ContactQuery
{
    public class GetAllContactAdminQuery : IRequest<IEnumerable<ContactAdminDTO>>
    {
        public class GetAllContactAdminQueryHandler : IRequestHandler<GetAllContactAdminQuery, IEnumerable<ContactAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllContactAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<ContactAdminDTO>> Handle(GetAllContactAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<ContactAdminDTO>>(await _unitOfWork.Contacts.GetAll());
            }
        }
    }

    public class GetAllContactClientQuery : IRequest<IEnumerable<ContactClientDTO>>
    {
        public class GetAllContactClientQueryHandler : IRequestHandler<GetAllContactClientQuery, IEnumerable<ContactClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllContactClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<ContactClientDTO>> Handle(GetAllContactClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<ContactClientDTO>>(await _unitOfWork.Contacts.GetAll());
            }
        }
    }
}
