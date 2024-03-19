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
        private readonly IMediator _mediator;
        public InfoControllerApplication(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("faqs")]
        public async Task<IActionResult> GetAllFaqs()
        {
            try
            {
                var responseData = await _mediator.Call(new GetAllFaqs());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("abouts")]
        public async Task<IActionResult> GetAllAbout()
        {
            try
            {
                var responseData = await _mediator.Call(new GetAllAbouts());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpPost("user-contact/create")]
        public async Task<IActionResult> SaveUserContact()
        {
            try
            {
                var responseData = await _mediator.Call(new SaveUserContact());
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }

        [HttpGet("detail-entrence-exam/{rollNumber}")]
        public async Task<IActionResult> GetDetailEntrenceExam(string rollNumber)
        {
            try
            {
                var responseData = await _mediator.Call(new GetDetailEntrenceExam(rollNumber));
                return Ok(responseData);
            }
            catch (Exception e)
            {
                return new ObjectResult(new { message = e.Message }) { StatusCode = 500 };
            }
        }
    }
}
