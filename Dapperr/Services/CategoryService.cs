using Dapperr.Context;
using Dapperr.Dtos.CategoryDtos;

namespace Dapperr.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DapperContext _context;
        public CategoryService(DapperContext context)
        {
            _context = context;
        }
        public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
