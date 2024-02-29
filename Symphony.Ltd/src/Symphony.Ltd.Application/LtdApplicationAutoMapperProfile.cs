using System;
using Symphony.Ltd.Shared;
using Volo.Abp.AutoMapper;
using Symphony.Ltd.Courses;
using AutoMapper;

namespace Symphony.Ltd;

public class LtdApplicationAutoMapperProfile : Profile
{
    public LtdApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Course, CourseDto>();
    }
}