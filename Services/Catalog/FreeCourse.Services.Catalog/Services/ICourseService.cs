using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
    interface ICourseService
    {
        /// <summary>
        /// Get all courses.
        /// </summary>
        /// <returns></returns>
        Task<Response<List<CourseDto>>> GetAllAsync();

        /// <summary>
        /// Get course by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Response<CourseDto>> GetByIdAsync(string id);

        Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);

        /// <summary>
        /// Adds new course.
        /// </summary>
        /// <param name="courseCreateDto"></param>
        /// <returns></returns>
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);

        /// <summary>
        /// Update course.
        /// </summary>
        /// <param name="courseUpdateDto"></param>
        /// <returns></returns>
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);

        /// <summary>
        /// Soft remove course by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Response<NoContent>> DeleteAsync(string id);
    }
}
