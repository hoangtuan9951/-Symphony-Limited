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
    public class UpdateAboutCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public required IFormFile BackgroundImage { get; set; }
        public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand, Unit>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IWebHostEnvironment _env;
            public UpdateAboutCommandHandler(IUnitOfWork unitOfWork, IWebHostEnvironment env)
            {
                _unitOfWork = unitOfWork;
                _env = env;
            }
            public async Task<Unit> Handle(UpdateAboutCommand command, CancellationToken cancellationToken)
            {

                About data = await _unitOfWork.Abouts.GetById(command.Id);

                string oldImageName = data.BackgroundImage.Split('/').Last();
                string oldImagePath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Other", oldImageName);
                File.Delete(oldImagePath);

                string extension = Path.GetExtension(ContentDispositionHeaderValue.Parse(command.BackgroundImage.ContentDisposition).FileName!.Trim('"'));
                string fileName = FileHelper.CreateImageFileName("about", extension);
                string filepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Other", fileName);
                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await command.BackgroundImage.CopyToAsync(stream);
                }

                data.Description = command.Description;
                data.LastUpdatedDate = DateTime.Now;
                data.BackgroundImage = FileHelper.ImageFileUri(fileName);

                await _unitOfWork.Complete();
                return Unit.Value;
            }
        }
    }
}
