using AutoMapper;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.ApplicationDTOs;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IService.IApplicationService;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.ApplicationService
{
    public class CourseServiceApplication : ICourseServiceApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CourseServiceApplication(IUnitOfWork unitOfWork,
                                        IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CourseAppDTO>> GetAll()
        {
            try
            {
                return _mapper.Map<IEnumerable<CourseAppDTO>>(await _unitOfWork.Courses.GetAll());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CourseDetailAppDTO> GetDetail(int id)
        {
            try
            {
                return _mapper.Map<CourseDetailAppDTO>(await _unitOfWork.Courses.GetById(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<CourseAppDTO>> GetSixLatestCourse()
        {
            try
            {
                return _mapper.Map<IEnumerable<CourseAppDTO>>(await _unitOfWork.Courses.GetSixLatestCourse());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
