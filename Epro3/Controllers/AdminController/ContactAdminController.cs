using Epro3.Application.Features.Commands.ContactCommand;
using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Application.Features.Queries.ContactQuery;
using Epro3.Application.Features.Queries.CourseQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.AdminController
{
    [Route("api/admin/contacts")]
    [ApiController]
    public class ContactAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContactAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContact()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllContactAdminQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetContactByIdAdminQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactCommand command)
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
        public async Task<IActionResult> Update(UpdateContactCommand command)
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
                await _mediator.Send(new DeleteContactCommand { Id = id });
                return new ObjectResult(null) { StatusCode = StatusCodes.Status204NoContent };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
