using Epro3.Application.Features.Queries.ContactQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/contacts")]
    [ApiController]
    public class ContactClientController : Controller
    {
        private readonly IMediator _mediator;
        public ContactClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContact()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllContactClientQuery());
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
                var responseData = await _mediator.Send(new GetContactByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
