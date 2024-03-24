using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Class;
using Epro3.Application.DTOs.ClientDTOs.Class;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.ClassQuery
{
    public class GetClassByIdAdminQuery : IRequest<ClassDetailAdminDTO>
    {
        public int Id { get; set; }
        public class GetClassByIdAdminQueryHandler : IRequestHandler<GetClassByIdAdminQuery, ClassDetailAdminDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetClassByIdAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<ClassDetailAdminDTO> Handle(GetClassByIdAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<ClassDetailAdminDTO>(await _unitOfWork.Classes.GetById(command.Id));
            }
        }
    }

    public class GetClassByIdClientQuery : IRequest<ClassDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetClassByIdClientQueryHandler : IRequestHandler<GetClassByIdClientQuery, ClassDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetClassByIdClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<ClassDetailClientDTO> Handle(GetClassByIdClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<ClassDetailClientDTO>(await _unitOfWork.Classes.GetById(command.Id));
            }
        }
    }
}
