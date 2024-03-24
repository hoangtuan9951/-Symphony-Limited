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
        public async Task<IActionResult> GetAllEntranceExam()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllEntranceExamClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEntranceExamDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetEntranceExamByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
