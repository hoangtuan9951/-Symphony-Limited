using Epro3.Application.Helpers;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
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
    public class UpdateCourseCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Amount { get; set; }
        public decimal Discount { get; set; }
        public required string Description { get; set; }
        public IFormFile? Thumbnail { get; set; }
        public IFormFile? BackGroundImage { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndedDate { get; set; }
        public bool Active { get; set; }
        public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IWebHostEnvironment _env;
            public UpdateCourseCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _env = env;
            }
            public async Task<Unit> Handle(UpdateCourseCommand command, CancellationToken cancellationToken)
            {

                Course data = await _unitOfWork.Courses.GetById(command.Id);

                if (command.Thumbnail != null)
                {
                    //delete old thumbnail image
                    string oldImageName = data.Thumbnail.Split('/').Last();
                    string oldImagePath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", oldImageName);
                    File.Delete(oldImagePath);

                    //save thumbnail image file
                    string thumbnailExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.Thumbnail.ContentDisposition).FileName!.Trim('"'));
                    string thumbnailFileName = FileHelper.CreateCourseThumbnailFileName(command.Name, thumbnailExtension);
                    string thumbnailFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", thumbnailFileName);
                    using (var stream = new FileStream(thumbnailFilepath, FileMode.Create))
                    {
                        await command.Thumbnail.CopyToAsync(stream);
                    }
                    data.Thumbnail = FileHelper.CourseImageFileUri(thumbnailFileName);
                }

                if(command.BackGroundImage != null)
                {
                    //delete old background image
                    string oldImageName = data.BackGroundImage.Split('/').Last();
                    string oldImagePath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", oldImageName);
                    File.Delete(oldImagePath);

                    //save background image file
                    string bgExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.BackGroundImage.ContentDisposition).FileName!.Trim('"'));
                    string bgFileName = FileHelper.CreateCourseBackgroundFileName(command.Name, bgExtension);
                    string bgFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", bgFileName);
                    using (var stream = new FileStream(bgFilepath, FileMode.Create))
                    {
                        await command.BackGroundImage.CopyToAsync(stream);
                    }
                    data.BackGroundImage = FileHelper.CourseImageFileUri(bgFileName);
                }

                data.Name = command.Name;
                data.Amount = command.Amount;
                data.Discount = command.Discount;
                data.Description = command.Description;
                data.Active = command.Active;
                data.StartedDate = command.StartedDate;
                data.EndedDate = command.EndedDate;

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
