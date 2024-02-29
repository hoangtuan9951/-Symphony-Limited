using Symphony.Ltd.Shared;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Symphony.Ltd.Courses;

namespace Symphony.Ltd.Web.Pages.Courses
{
    public class CreateModalModel : LtdPageModel
    {

        [BindProperty]
        public CourseCreateViewModel Course { get; set; }

        protected ICoursesAppService _coursesAppService;

        public CreateModalModel(ICoursesAppService coursesAppService)
        {
            _coursesAppService = coursesAppService;

            Course = new();
        }

        public virtual async Task OnGetAsync()
        {
            Course = new CourseCreateViewModel();

            await Task.CompletedTask;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {

            await _coursesAppService.CreateAsync(ObjectMapper.Map<CourseCreateViewModel, CourseCreateDto>(Course));
            return NoContent();
        }
    }

    public class CourseCreateViewModel : CourseCreateDto
    {
    }
}