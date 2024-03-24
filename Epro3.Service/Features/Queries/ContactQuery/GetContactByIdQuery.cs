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
    public class GetContactByIdAdminQuery : IRequest<ContactDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetContactByIdAdminQueryHandler : IRequestHandler<GetContactByIdAdminQuery, ContactDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetContactByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<ContactDetailAdminDTO> Handle(GetContactByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<ContactDetailAdminDTO>(await _unitOfWork.Contacts.GetById(command.Id));
            }
        }
    }

    public class GetContactByIdClientQuery : IRequest<ContactDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetContactByIdClientQueryHandler : IRequestHandler<GetContactByIdClientQuery, ContactDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetContactByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<ContactDetailClientDTO> Handle(GetContactByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<ContactDetailClientDTO>(await _unitOfWork.Contacts.GetById(command.Id));
            }
        }
    }
}
