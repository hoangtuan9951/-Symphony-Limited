using AutoMapper;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.DTOs.AdminDTOs.CourseDetail;
using Epro3.Domain.Entities;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Domain.Interfaces.IService.IAdminService;
using Epro3.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Service.AdminService
{
    public class CourseServiceAdmin : ICourseServiceAdmin
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CourseServiceAdmin(IUnitOfWork unitOfWork, IMapper mapper) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public async Task Create(CreateCourseDTO createCourseDTO, CreateCourseDetailDTO createCourseDetailDTO)
        {
            _unitOfWork.Courses.Create(_mapper.Map<Course>(createCourseDTO));
            _unitOfWork.CourseDetails.Create(_mapper.Map<CourseDetail>(createCourseDetailDTO));
            await _unitOfWork.Complete();
        }

        public Task Delete()
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAll()
        {
            _unitOfWork.Courses.GetAll();
            await _unitOfWork.Complete();
        }

        public Task GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, UpdateCourseDTO updateCourseDTO)
        {
            throw new NotImplementedException();
        }

        Task<GetCourseDetailDTO> ICourseServiceAdmin.GetDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
