using AutoMapper;
using Epro3.Domain.DTOs.AdminDTOs.Course;
using Epro3.Domain.Entities;
using Epro3.Domain.Helpers;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IService.IAdminService;
using Epro3.Infrastructure.Repositories;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Epro3.Application.AdminService
{
    public class CourseServiceAdmin : ICourseAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public CourseServiceAdmin(IUnitOfWork unitOfWork,
                                  IMapper mapper,
                                  IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _env = env;
        }

        public async Task Create(CreateCourseDTO createCourseDTO)
        {
            try
            {
                //save thumbnail image file
                string thumbnailExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(createCourseDTO.Thumbnail.ContentDisposition).FileName!.Trim('"'));
                string thumbnailFileName = FileHelper.CreateCourseThumbnailFileName(createCourseDTO.Name, thumbnailExtension);
                string thumbnailFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", thumbnailFileName);
                using (var stream = new FileStream(thumbnailFilepath, FileMode.Create))
                {
                    await createCourseDTO.Thumbnail.CopyToAsync(stream);
                }

                //save background image file
                string bgExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(createCourseDTO.BackGroundImage.ContentDisposition).FileName!.Trim('"'));
                string bgFileName = FileHelper.CreateCourseBackgroundFileName(createCourseDTO.Name, bgExtension);
                string bgFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", bgFileName);
                using (var stream = new FileStream(bgFilepath, FileMode.Create))
                {
                    await createCourseDTO.BackGroundImage.CopyToAsync(stream);
                }

                Course course = new Course
                {
                    Name = createCourseDTO.Name,
                    Code = createCourseDTO.Code,
                    Amount = createCourseDTO.Amount,
                    Discount = createCourseDTO.Discount,
                    Description = createCourseDTO.Description,
                    Active = createCourseDTO.Active,
                    CreatedDate = DateTime.Now,
                    StartedDate = createCourseDTO.StartedDate,
                    EndedDate = createCourseDTO.EndedDate,
                    Thumbnail = FileHelper.CourseImageFileUri(thumbnailFileName),
                    BackGroundImage = FileHelper.CourseImageFileUri(bgFileName),
                    Slug = SlugHelper.CourseSlugGenerate(createCourseDTO.Name)
                };
                _unitOfWork.Courses.Create(course);
                await _unitOfWork.Complete();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                Course data = await _unitOfWork.Courses.GetById(id);
                _unitOfWork.Courses.Delete(data);
                await _unitOfWork.Complete();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<CourseAdminDTO>> GetAll()
        {
            try
            {
                return _mapper.Map<IEnumerable<CourseAdminDTO>>(await _unitOfWork.Courses.GetAll());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CourseDetailAdminDTO> GetDetail(int id)
        {
            try
            {
                return _mapper.Map<CourseDetailAdminDTO>(await _unitOfWork.Courses.GetById(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task Update(int id, UpdateCourseDTO updateCourseDTO)
        {
            try
            {
                Course data = await _unitOfWork.Courses.GetById(id);

                //delete old thumbnail image
                string oldImageName = data.Thumbnail.Split('/').Last();
                string oldImagePath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", oldImageName);
                File.Delete(oldImagePath);

                //delete old background image
                oldImageName = data.BackGroundImage.Split('/').Last();
                oldImagePath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", oldImageName);
                File.Delete(oldImagePath);

                //save thumbnail image file
                string thumbnailExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(updateCourseDTO.Thumbnail.ContentDisposition).FileName!.Trim('"'));
                string thumbnailFileName = FileHelper.CreateCourseThumbnailFileName(updateCourseDTO.Name, thumbnailExtension);
                string thumbnailFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", thumbnailFileName);
                using (var stream = new FileStream(thumbnailFilepath, FileMode.Create))
                {
                    await updateCourseDTO.Thumbnail.CopyToAsync(stream);
                }

                //save background image file
                string bgExtension = Path.GetExtension(ContentDispositionHeaderValue.Parse(updateCourseDTO.BackGroundImage.ContentDisposition).FileName!.Trim('"'));
                string bgFileName = FileHelper.CreateCourseBackgroundFileName(updateCourseDTO.Name, bgExtension);
                string bgFilepath = Path.Combine(_env.ContentRootPath, "volume/Resource/Image/Course", bgFileName);
                using (var stream = new FileStream(bgFilepath, FileMode.Create))
                {
                    await updateCourseDTO.BackGroundImage.CopyToAsync(stream);
                }

                data.Name = updateCourseDTO.Name;
                data.Amount = updateCourseDTO.Amount;
                data.Discount = updateCourseDTO.Discount;
                data.Description = updateCourseDTO.Description;
                data.Active = updateCourseDTO.Active;
                data.StartedDate = updateCourseDTO.StartedDate;
                data.EndedDate = updateCourseDTO.EndedDate;
                data.Thumbnail = FileHelper.CourseImageFileUri(thumbnailFileName);
                data.BackGroundImage = FileHelper.CourseImageFileUri(bgFileName);

                _unitOfWork.Courses.Delete(data);
                await _unitOfWork.Complete();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }


}
