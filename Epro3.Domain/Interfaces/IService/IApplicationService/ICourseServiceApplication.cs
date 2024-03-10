using Epro3.Domain.DTOs.ApplicationDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Domain.Interfaces.IService.IApplicationService
{
    public interface ICourseServiceApplication
    {
        Task<IEnumerable<CourseAppDTO>> GetAll();
        Task<IEnumerable<CourseAppDTO>> GetSixLatestCourse();
        Task<CourseDetailAppDTO> GetDetail(int id);
    }
}
