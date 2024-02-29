using Symphony.Ltd.Web.Pages.Courses;
using Volo.Abp.AutoMapper;
using Symphony.Ltd.Courses;
using AutoMapper;

namespace Symphony.Ltd.Web;

public class LtdWebAutoMapperProfile : Profile
{
    public LtdWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project

        CreateMap<CourseDto, CourseUpdateViewModel>();
        CreateMap<CourseUpdateViewModel, CourseUpdateDto>();
        CreateMap<CourseCreateViewModel, CourseCreateDto>();
    }
}