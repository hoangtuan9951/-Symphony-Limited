using Epro3.Application.Features.Commands.AboutCommand;
using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Application.Features.Queries.AboutQuery;
using Epro3.Application.Features.Queries.CourseQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.AdminController
{
    [Route("api/admin/abouts")]
    [ApiController]
    public class AboutAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAbout()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllAboutAdminQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAboutCommand command)
        {
            try
            {
                await _mediator.Send(command);
                return Ok();
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAboutCommand command)
        {
            try
            {
                await _mediator.Send(command);
                return new ObjectResult(null) { StatusCode = StatusCodes.Status201Created };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _mediator.Send(new DeleteCourseCommand { Id = id });
                return new ObjectResult(null) { StatusCode = StatusCodes.Status204NoContent };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
