using Epro3.Application.Features.Queries.EntranceExamStudentResultQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/entrance-exam-student-results")]
    [ApiController]
    public class EntranceExamStudentResultClientController : Controller
    {
        private readonly IMediator _mediator;
        public EntranceExamStudentResultClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntranceExamStudentResult()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllEntranceExamStudentResultClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEntranceExamStudentResultDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetEntranceExamStudentResultByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
