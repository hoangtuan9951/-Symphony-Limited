using Symphony.Ltd.Shared;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Symphony.Ltd.Courses;

namespace Symphony.Ltd.Web.Pages.Courses
{
    public class EditModalModel : LtdPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CourseUpdateViewModel Course { get; set; }

        protected ICoursesAppService _coursesAppService;

        public EditModalModel(ICoursesAppService coursesAppService)
        {
            _coursesAppService = coursesAppService;

            Course = new();
        }

        public virtual async Task OnGetAsync()
        {
            var course = await _coursesAppService.GetAsync(Id);
            Course = ObjectMapper.Map<CourseDto, CourseUpdateViewModel>(course);

        }

        public virtual async Task<NoContentResult> OnPostAsync()
        {

            await _coursesAppService.UpdateAsync(Id, ObjectMapper.Map<CourseUpdateViewModel, CourseUpdateDto>(Course));
            return NoContent();
        }
    }

    public class CourseUpdateViewModel : CourseUpdateDto
    {
    }
}