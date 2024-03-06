using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.CourseDetail;
using Epro3.Domain.Interfaces.IService.IAdminService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Epro3.Controllers.AdminController
{
    [Route("api/admin/quizzes/fill-blank")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class CourseControllerAdmin : ControllerBase
    {
        private readonly ICourseServiceAdmin _courseServiceAdmin;
        public CourseControllerAdmin(ICourseServiceAdmin courseServiceAdmin)
        {
            _courseServiceAdmin = courseServiceAdmin;
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetDetail(int id)
        {
            try
            {
                return Ok(await _courseServiceAdmin.GetDetail(id));
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCourseDTO createCourseDTO, CreateCourseDetailDTO createCourseDetailDTO)
        {
            try
            {
                await _courseServiceAdmin.Create(createCourseDTO, createCourseDetailDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCourseDTO updateCourseDTO)
        {
            try
            {
                await _courseServiceAdmin.Update(id, updateCourseDTO);
                return new ObjectResult(null) { StatusCode = StatusCodes.Status201Created };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _courseServiceAdmin.Delete(id);
                return new ObjectResult(null) { StatusCode = StatusCodes.Status204NoContent };
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
