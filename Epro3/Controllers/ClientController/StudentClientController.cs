using Epro3.Application.Features.Queries.StudentQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ClientController
{
    [Route("api/client/students")]
    [ApiController]
    public class StudentClientController : Controller
    {
        private readonly IMediator _mediator;
        public StudentClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllStudentClientQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetStudentByIdClientQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
