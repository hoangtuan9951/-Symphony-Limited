using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Application.Features.Queries.ClassQuery;
using Epro3.Application.Features.Queries.CourseQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.AdminController
{
    [Route("api/admin/classes")]
    [ApiController]
    public class ClassAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClassAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClass()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllClassAdminQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetClassByIdAdminQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClassCommand command)
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
        public async Task<IActionResult> Update(UpdateClassCommand command)
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
                await _mediator.Send(new DeleteClassCommand { Id = id });
                return new ObjectResult(null) { StatusCode = StatusCodes.Status204NoContent };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
