using AutoMapper;
using Epro3.Application.DTOs.AdminDTOs.About;
using Epro3.Application.DTOs.AdminDTOs.Class;
using Epro3.Application.DTOs.AdminDTOs.Contact;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.AdminDTOs.CourseModule;
using Epro3.Application.DTOs.AdminDTOs.EntranceExam;
using Epro3.Application.DTOs.AdminDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.AdminDTOs.FAQ;
using Epro3.Application.DTOs.AdminDTOs.Student;
using Epro3.Application.DTOs.ClientDTOs.About;
using Epro3.Application.DTOs.ClientDTOs.Class;
using Epro3.Application.DTOs.ClientDTOs.Contact;
using Epro3.Application.DTOs.ClientDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs.CourseModule;
using Epro3.Application.DTOs.ClientDTOs.EntranceExam;
using Epro3.Application.DTOs.ClientDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.ClientDTOs.FAQ;
using Epro3.Application.DTOs.ClientDTOs.Student;
using Epro3.Domain.Entities;

namespace Epro3.Application.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            #region About
            CreateMap<About, AboutClientDTO>();
            CreateMap<About, AboutAdminDTO>();
            #endregion

            #region Class
            CreateMap<Class, ClassClientDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<Class, ClassDetailClientDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<Class, ClassAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<Class, ClassDetailAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            #endregion

            #region Contact
            CreateMap<Contact, ContactClientDTO>();
            CreateMap<Contact, ContactDetailClientDTO>();
            CreateMap<Contact, ContactAdminDTO>();
            CreateMap<Contact, ContactDetailAdminDTO>();
            #endregion

            #region Course
            CreateMap<Course, CourseClientDTO>();
            CreateMap<Course, CourseDetailClientDTO>();
            CreateMap<Course, CourseAdminDTO>();
            CreateMap<Course, CourseDetailAdminDTO>();
            #endregion

            #region CourseModule
            CreateMap<CourseModule, CourseModuleClientDTO>();
            CreateMap<CourseModule, CourseModuleDetailClientDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<CourseModule, CourseModuleAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            CreateMap<CourseModule, CourseModuleDetailAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name));
            #endregion

            #region EntranceExam
            CreateMap<EntranceExam, EntranceExamClientDTO>();
            CreateMap<EntranceExam, EntranceExamAdminDTO>();
            CreateMap<EntranceExam, EntranceExamDetailAdminDTO>();
            #endregion

            #region EntranceExamStudentResult
            CreateMap<EntranceExamStudentResult, EntranceExamStudentResultClientDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name))
                                                                                      .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student.Name))
                                                                                      .ForMember(dest => dest.EntranceExam, opt => opt.MapFrom(src => src.EntranceExam.Name));
            CreateMap<EntranceExamStudentResult, EntranceExamStudentResultDetailClientDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name))
                                                                                            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student.Name))
                                                                                            .ForMember(dest => dest.EntranceExam, opt => opt.MapFrom(src => src.EntranceExam.Name));
            CreateMap<EntranceExamStudentResult, EntranceExamStudentResultAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name))
                                                                                     .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student.Name))
                                                                                     .ForMember(dest => dest.EntranceExam, opt => opt.MapFrom(src => src.EntranceExam.Name));
            CreateMap<EntranceExamStudentResult, EntranceExamStudentResultDetailAdminDTO>().ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.Course.Name))
                                                                                           .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student.Name))
                                                                                           .ForMember(dest => dest.EntranceExam, opt => opt.MapFrom(src => src.EntranceExam.Name));
            #endregion

            #region FAQ
            CreateMap<FAQ, FAQClientDTO>();
            CreateMap<FAQ, FAQDetailClientDTO>();
            CreateMap<FAQ, FAQAdminDTO>();
            CreateMap<FAQ, FAQDetailAdminDTO>();
            #endregion

            #region Student
            CreateMap<Student, StudentClientDTO>();
            CreateMap<Student, StudentDetailClientDTO>();
            CreateMap<Student, StudentAdminDTO>();
            CreateMap<Student, StudentDetailAdminDTO>();
            #endregion
        }
    }
}
