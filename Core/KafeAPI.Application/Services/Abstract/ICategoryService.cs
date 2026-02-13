using KafeAPI.Application.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeAPI.Application.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategories();
        Task<DetailCategoryDto> GetByIdCategory(int id);
        Task AddCategory(CreateCategoryDto dto);
        Task UpdateCategory(UpdateCategoryDto dto);
        Task DeleteCategory(int id);    
    }
}
