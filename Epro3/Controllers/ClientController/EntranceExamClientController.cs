using Epro3.Application.Features.Queries.EntranceExamQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/entrance-exams")]
    [ApiController]
    public class EntranceExamClientController : Controller
    {
        private readonly IMediator _mediator;
        public EntranceExamClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetLatestEntranceExam()
        {
            try
            {
                var responseData = await _mediator.Send(new GetLatestEntranceExamClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
