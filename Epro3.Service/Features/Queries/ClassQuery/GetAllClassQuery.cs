using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Class;
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
    public class GetAllClassAdminQuery : IRequest<IEnumerable<ClassAdminDTO>>
    {
        public class GetAllClassAdminQueryHandler : IRequestHandler<GetAllClassAdminQuery, IEnumerable<ClassAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllClassAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<ClassAdminDTO>> Handle(GetAllClassAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<ClassAdminDTO>>(await _unitOfWork.Classes.GetAll());
            }
        }
    }

    public class GetAllClassClientQuery : IRequest<IEnumerable<ClassClientDTO>>
    {
        public class GetAllClassClientQueryHandler : IRequestHandler<GetAllClassClientQuery, IEnumerable<ClassClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllClassClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<ClassClientDTO>> Handle(GetAllClassClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<ClassClientDTO>>(await _unitOfWork.Classes.GetAll());
            }
        }
    }
}
