using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Services
{
    interface ICategoryService
    {
        /// <summary>
        /// Get all categories.
        /// </summary>
        /// <returns></returns>
        Task<Response<List<CategoryDto>>> GetAllAsync();

        /// <summary>
        /// Adds new category.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<Response<CategoryDto>> CreateAsync(Category category);

        /// <summary>
        /// Lists categories by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
