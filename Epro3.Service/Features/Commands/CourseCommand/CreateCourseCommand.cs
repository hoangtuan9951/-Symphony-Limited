using AutoMapper;
using Epro3.Application.Helpers;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
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

namespace Epro3.Application.Features.Commands.CourseCommand
{
    public class CreateCourseCommand : IRequest<Unit>
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

        public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IWebHostEnvironment _env;
            public CreateCourseCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _env = env;
            }

            public async Task<Unit> Handle(CreateCourseCommand command, CancellationToken cancellationToken)
            {
                //save thumbnail image file
                string thumbnailExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.Thumbnail.ContentDisposition).FileName!.Trim('"'));
                string thumbnailFileName = FileHelper.CreateCourseThumbnailFileName(command.Name, thumbnailExtension);
                string thumbnailFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", thumbnailFileName);
                using (var stream = new FileStream(thumbnailFilepath, FileMode.Create))
                {
                    await command.Thumbnail.CopyToAsync(stream);
                }

                //save background image file
                string bgExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.BackGroundImage.ContentDisposition).FileName!.Trim('"'));
                string bgFileName = FileHelper.CreateCourseBackgroundFileName(command.Name, bgExtension);
                string bgFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", bgFileName);
                using (var stream = new FileStream(bgFilepath, FileMode.Create))
                {
                    await command.BackGroundImage.CopyToAsync(stream);
                }

                Course course = new Course
                {
                    Name = command.Name,
                    Code = command.Code,
                    Amount = command.Amount,
                    Discount = command.Discount,
                    Description = command.Description,
                    Active = command.Active,
                    CreatedDate = DateTime.Now,
                    StartedDate = command.StartedDate,
                    EndedDate = command.EndedDate,
                    Thumbnail = FileHelper.CourseImageFileUri(thumbnailFileName),
                    BackGroundImage = FileHelper.CourseImageFileUri(bgFileName),
                    Slug = SlugHelper.CourseSlugGenerate(command.Name)
                };
                _unitOfWork.Courses.Create(course);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
