using Epro3.Domain.Interfaces.IService.IAdminService;
using Epro3.Domain.Interfaces.IService.IApplicationService;
using Epro3.Service.AdminService;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ApplicationController
{
    [Route("api/application/courses")]
    [ApiController]
    public class CourseControllerApplication : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseControllerApplication(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCourse()
        {
            try
            {
                var responseData = await _mediator.Send(new GetAllCourseApplicationQuery());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseDetail(int id)
        {
            try
            {
                var responseData = await _mediator.Send(new GetCourseByIdApplicationQuery { Id = id});
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("latest-course")]
        public async Task<IActionResult> GetSixLatestCourse()
        {
            try
            {
                var responseData = await _mediator.Send(new GetSixLatestCourse());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
