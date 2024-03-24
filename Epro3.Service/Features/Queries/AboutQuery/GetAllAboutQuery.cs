using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.About;
using Epro3.Application.DTOs.ClientDTOs;
using Epro3.Application.DTOs.ClientDTOs.About;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.AboutQuery
{
    public class GetAllAboutAdminQuery : IRequest<IEnumerable<AboutAdminDTO>>
    {
        public class GetAllAboutAdminQueryHandler : IRequestHandler<GetAllAboutAdminQuery, IEnumerable<AboutAdminDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllAboutAdminQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<AboutAdminDTO>> Handle(GetAllAboutAdminQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<AboutAdminDTO>>(await _unitOfWork.Abouts.GetAll());
            }
        }
    }

    public class GetAllAboutClientQuery : IRequest<IEnumerable<AboutClientDTO>>
    {
        public class GetAllAboutClientQueryHandler : IRequestHandler<GetAllAboutClientQuery, IEnumerable<AboutClientDTO>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            public GetAllAboutClientQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<IEnumerable<AboutClientDTO>> Handle(GetAllAboutClientQuery command, CancellationToken cancellationToken)
            {
                return _mapper.Map<IEnumerable<AboutClientDTO>>(await _unitOfWork.Abouts.GetAll());
            }
        }
    }
}
