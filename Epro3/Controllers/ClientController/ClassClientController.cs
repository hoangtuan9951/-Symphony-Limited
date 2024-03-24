using Epro3.Application.Features.Queries.ClassQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/classes")]
    [ApiController]
    public class ClassClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClassClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClass()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllClassClientQuery());
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
                var responseData = await _mediator.Send(new GetClassByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
