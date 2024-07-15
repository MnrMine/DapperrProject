using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.PropertyTypeDto;

namespace Dapperr.Services.PropertyTypeService
{
	public class PropertyTypeService : IPropertyTypeService
	{
		private readonly DapperContext _context;

		public PropertyTypeService(DapperContext context)
		{
			_context = context;
		}

		public async Task<List<ResultPropertyTypeDto>> GetAllTypeAsync()
		{
			string query = "Select * From TblPropertyType";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultPropertyTypeDto>(query);
			return values.ToList();
		}
	}
}
