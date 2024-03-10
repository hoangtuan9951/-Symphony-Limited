using AutoMapper;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.ApplicationDTOs;
using Epro3.Domain.Entities;

namespace Epro3.Domain.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            #region Course
            CreateMap<Course, CourseAppDTO>();
            CreateMap<Course, CourseDetailAppDTO>();
            CreateMap<Course, CourseAdminDTO>();
            CreateMap<Course, CourseDetailAdminDTO>();
            #endregion
        }
    }
}
