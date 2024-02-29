using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Symphony.Ltd.Courses
{
    public class CourseCreateDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Guid? TeacherId { get; set; }
        public string? Price { get; set; }
        public Guid? TopicId { get; set; }
        public string? LearnTime { get; set; }
    }
}