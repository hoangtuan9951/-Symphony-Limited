using Epro3.Domain.Interfaces.IService.IAdminService;
using Epro3.Domain.Interfaces.IService.IApplicationService;
using Epro3.Service.AdminService;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.ApplicationController
{
    [Route("api/application/info")]
    [ApiController]
    public class InfoControllerApplication : ControllerBase
    {
        private readonly ICourseServiceApplication _courseServiceApplication;
        public InfoControllerApplication(ICourseServiceApplication courseServiceApplication)
        {
            _courseServiceApplication = courseServiceApplication;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourse()
        {
            try
            {
                var responseData = await _courseServiceApplication.GetAll();
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
                var responseData = await _courseServiceApplication.GetDetail(id);
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
                var responseData = await _courseServiceApplication.GetSixLatestCourse();
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
