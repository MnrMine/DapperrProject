using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.ImagesDto;

namespace Dapperr.Services.ImagesService
{
	public class ImagesService : IImagesService
	{
		private readonly DapperContext _context;

		public ImagesService(DapperContext context)
		{
			_context = context;
		}

		public async Task<List<ResultImageDto>> GetAllImageAsync()
		{
			string query = "Select * From Tbl_Images";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultImageDto>(query);
			return values.ToList();
		}
	}
}
