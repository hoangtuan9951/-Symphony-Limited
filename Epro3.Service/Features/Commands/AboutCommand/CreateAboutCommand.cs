using AutoMapper;
using Epro3.Application.Features.Commands.CourseCommand;
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

namespace Epro3.Application.Features.Commands.AboutCommand
{
    public class CreateAboutCommand : IRequest<Unit>
    {
        public string Description { get; set; } = string.Empty;
        public required IFormFile BackgroundImage { get; set; }

        public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IWebHostEnvironment _env;
            public CreateAboutCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _env = env;
            }

            public async Task<Unit> Handle(CreateAboutCommand command, CancellationToken cancellationToken)
            {

                string extension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.BackgroundImage.ContentDisposition).FileName!.Trim('"'));
                string fileName = FileHelper.CreateCourseThumbnailFileName("about", extension);
                string filepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Other", fileName);
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await command.BackgroundImage.CopyToAsync(stream);
                }

                About about = new About
                {
                    Description = command.Description,
                    BackgroundImage = FileHelper.ImageFileUri(fileName),
                    LastUpdatedDate = DateTime.Now,
                };
                _unitOfWork.Abouts.Create(about);
                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
