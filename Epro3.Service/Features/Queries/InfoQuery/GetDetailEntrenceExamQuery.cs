using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs;
using Epro3.Application.Features.Commands;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Queries.CourseQuery
{
    public class GetDetailEntrenceExamQuery : IRequest<IEnumerable<AboutClientDTO>>
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
                return _mapper.Map<IEnumerable<AboutClientDTO>>(await _unitOfWork.EntrenceExam.GetAll());
            }
        }
    }
}
