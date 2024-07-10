using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.ProductDtos;

namespace Dapperr.Services.ProductService.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DapperContext _context;
        public ProductService(DapperContext context)
        {
            _context = context;
        }
        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            string query = "insert into TblProduct (ProductName,Price,Stock,CategoryId) values (@productName,@price,@stock,@categoryId)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", createProductDto.ProductName);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@stock", createProductDto.Stock);
            parameters.Add("@categoryId", createProductDto.CategoryId);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeleteProductAsync(int id)
        {
            string query = "Delete From TblProduct Where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From TblProduct";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductDto>(query);
            return values.ToList();
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductId,ProductName,Price,Stock,CategoryName From TblProduct Inner Join TblCategory On TblProduct.CategoryId=TblCategory.CategoryId";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
            return values.ToList();
        }

        public async Task<GetByIdProductDto> GetProductAsync(int id)
        {
            string query = "Select * From TblProduct Where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetByIdProductDto>(query, parameters);
            return value;
        }

        public async Task<int> GetProductCount()
        {
            string query = "Select Count(*) From TblProduct";
            var connection = _context.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            string query = "Update TblProduct Set ProductName=@p1, Price=@p2, Stock=@p3, CategoryId=@p4 where ProductId=@p5";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", updateProductDto.ProductName);
            parameters.Add("@p2", updateProductDto.Price);
            parameters.Add("@p3", updateProductDto.Stock);
            parameters.Add("@p4", updateProductDto.CategoryId);
            parameters.Add("@p5", updateProductDto.ProductId);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
