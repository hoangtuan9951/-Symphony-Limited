using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Application.Features.Commands.StudentCommand;
using Epro3.Application.Features.Queries.CourseQuery;
using Epro3.Application.Features.Queries.StudentQuery;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.AdminController
{
    [Route("api/admin/students")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class StudentAdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllStudentAdminQuery());
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
                var responseData = await _mediator.Send(new GetStudentByIdAdminQuery { Id = id });
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentCommand command)
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
        public async Task<IActionResult> Update(UpdateStudentCommand command)
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

        [HttpDelete]
        public async Task<IActionResult> Delete(string studentRollNumber)
        {
            try
            {
                await _mediator.Send(new DeleteStudentCommand { StudentRollNumber = studentRollNumber });
                return new ObjectResult(null) { StatusCode = StatusCodes.Status204NoContent };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
