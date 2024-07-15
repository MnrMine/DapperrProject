using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.LocationDto;

namespace Dapperr.Services.LocationService
{
	public class LocationService : ILocationService
	{
		private readonly DapperContext _context;

		public LocationService(DapperContext context)
		{
			_context = context;
		}
		public async Task<List<ResultLocationDto>> GetAllLocationAsync()
		{
			string query = "Select * From TblLocation";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultLocationDto>(query);
			return values.ToList();
		}

		public  async Task<int> GetLocationCount()
		{
			string query = "Select Count(*) From TblLocation";
			var connection = _context.CreateConnection();
			int value = await connection.QueryFirstOrDefaultAsync<int>(query);
			return value;
		}
	}
}
