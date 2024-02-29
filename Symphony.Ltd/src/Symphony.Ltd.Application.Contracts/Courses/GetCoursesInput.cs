using Volo.Abp.Application.Dtos;
using System;

namespace Symphony.Ltd.Courses
{
    public class GetCoursesInput : PagedAndSortedResultRequestDto
    {

        public string? FilterText { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? TeacherId { get; set; }
        public string? Price { get; set; }
        public Guid? TopicId { get; set; }
        public string? LearnTime { get; set; }

        public GetCoursesInput()
        {

        }
    }
}