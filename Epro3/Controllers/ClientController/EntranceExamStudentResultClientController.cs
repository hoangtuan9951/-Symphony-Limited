using Epro3.Application.Features.Queries.EntranceExamQuery;
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

        [HttpGet("last-over")]
        public async Task<IActionResult> GetLastOverEntranceExam()
        {
            try
            {
                var responseData = await _mediator.Send(new GetLastOverEntranceExamClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("result")]
        public async Task<IActionResult> GetEntranceExamStudentResultDetail(string studentRollNumber)
        {
            try
            {
                var responseData = await _mediator.Send(new GetEntranceExamStudentResultByStudentRollNumberClientQuery { StudentRollNumber = studentRollNumber });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
