using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Symphony.Ltd.Courses;
using Symphony.Ltd.Shared;

namespace Symphony.Ltd.Web.Pages.Courses
{
    public class IndexModel : AbpPageModel
    {
        public string? TitleFilter { get; set; }
        public string? DescriptionFilter { get; set; }
        public string? TeacherIdFilter { get; set; }
        public string? PriceFilter { get; set; }
        public string? TopicIdFilter { get; set; }
        public string? LearnTimeFilter { get; set; }

        protected ICoursesAppService _coursesAppService;

        public IndexModel(ICoursesAppService coursesAppService)
        {
            _coursesAppService = coursesAppService;
        }

        public virtual async Task OnGetAsync()
        {

            await Task.CompletedTask;
        }
    }
}