using Epro3.Application.Features.Queries.FAQQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/faqs")]
    [ApiController]
    public class FAQClientController : Controller
    {
        private readonly IMediator _mediator;
        public FAQClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFAQ()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllFAQClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFAQDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetFAQByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
