using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.TagDto;

namespace Dapperr.Services.TagService
{
	public class TagService : ITagService
	{
		private readonly DapperContext _context;

		public TagService(DapperContext context)
		{
			_context = context;
		}

		public async Task<List<ResultTagDto>> GetAllTagAsync()
		{
			string query = "Select * From TblTag";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultTagDto>(query);
			return values.ToList();
		}
	}
}
