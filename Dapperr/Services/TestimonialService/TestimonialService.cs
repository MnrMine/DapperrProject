using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.TestimonialDto;

namespace Dapperr.Services.TestimonialService
{
	public class TestimonialService : ITestimonialService
	{
		private readonly DapperContext _context;

		public TestimonialService(DapperContext context)
		{
			_context = context;
		}
		public async Task CreateTestimonialAsync(CreateTestiomonialDto createTestimonialDto)
		{
			throw new NotImplementedException();
		}

		public async Task DeleteTestimonialAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
		{
			string query = "Select * From TblTestimonial";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultTestimonialDto>(query);
			return values.ToList();
		}

		public async Task<GetByIdTestimonialDto> GetTestimonialAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
		{
			throw new NotImplementedException();
		}
	}
}
