using AutoMapper;
using Epro3.Application.Helpers;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Infrastructure.DBContext;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.Features.Commands.InfoCommand
{
    public class CreateUserContactCommand : IRequest<Unit>
    {
        public required string Name { get; set; }
        public required string Code { get; set; }
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public required string Description { get; set; }
        public required string CourseDetail { get; set; }
        public required IFormFile Thumbnail { get; set; }
        public required IFormFile BackGroundImage { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public bool Active { get; set; }

        public class CreateUsercontactCommandHandler : IRequestHandler<CreateUserContactCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IWebHostEnvironment _env;
            public CreateCourseCommandHandler(IUnitOfWork unitOfWork,
                                      IMapper mapper,
                                      IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
                _env = env;
            }

            public async Task<Unit> Handle(CreateCourseCommand command, CancellationToken cancellationToken)
            {
            
                Usercontact userContact = new UserContact
                {
                    Name = command.Name,
                    Code = command.Code,
                    Amount = command.Amount,
                    Discount = command.Discount,
                    Description = command.Description,
                    CourseDetail = command.CourseDetail,
                    Active = command.Active,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                    StartedDate = command.StartedDate,
                    EndedDate = command.EndedDate,
                    Thumbnail = FileHelper.CourseImageFileUri(thumbnailFileName),
                    BackGroundImage = FileHelper.CourseImageFileUri(bgFileName),
                    Slug = SlugHelper.CourseSlugGenerate(command.Name)
                };
                _unitOfWork.UserContact.Create(userContact);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
