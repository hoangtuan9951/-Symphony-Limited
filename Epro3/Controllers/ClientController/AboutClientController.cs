using Epro3.Application.Features.Queries.AboutQuery;
using Epro3.Application.Features.Queries.CourseQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/abouts")]
    [ApiController]
    public class AboutClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAbout()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllAboutClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
