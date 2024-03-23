using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs;
using Epro3.Domain.Entities;

namespace Epro3.Application.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            #region Course
            CreateMap<Course, CourseClientDTO>();
            CreateMap<Course, CourseDetailClientDTO>();
            CreateMap<Course, CourseAdminDTO>();
            CreateMap<Course, CourseDetailAdminDTO>();
            #endregion
        }
    }
}
