using AutoMapper;
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
    public class GetLastOverEntranceExamClientQuery : IRequest<EntranceExamDetailClientDTO>
    {
        public int Id { get; set; }
        public class GetLastOverEntranceExamClientQueryHandler : IRequestHandler<GetLastOverEntranceExamClientQuery, EntranceExamDetailClientDTO>
        {
            private readonly IUnitOfWork _unitOfWork;
            public GetLastOverEntranceExamClientQueryHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public async Task<EntranceExamDetailClientDTO> Handle(GetLastOverEntranceExamClientQuery command, CancellationToken cancellationToken)
            {
                var data = await _unitOfWork.EntranceExams.GetLastOverEntranceExamDetail();
                EntranceExamDetailClientDTO result = new EntranceExamDetailClientDTO();
                result.Id = data.Id;
                result.Name = data.Name;
                List<EntranceExamDetailDataDTO> dto = new List<EntranceExamDetailDataDTO>();
                foreach (var item in data.EntranceExamStudentResults) {
                    EntranceExamDetailDataDTO a = new EntranceExamDetailDataDTO {
                        Grade = item.Grade,
                        Name = item.Student.Name
                    };
                    dto.Add(a);
                }
                result.DTO = dto;
                return result;
            }
        }
    }
}
