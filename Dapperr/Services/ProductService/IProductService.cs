using Dapperr.Dtos.ProductDtos;

namespace Dapperr.Services.ProductService.ProductService
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task DeleteProductAsync(int id);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task<GetByIdProductDto> GetProductAsync(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        Task<int> GetProductCount();
    }
}
