using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.AgentDto;

namespace Dapperr.Services.AgentService
{
	public class AgentService : IAgentService
	{
		private readonly DapperContext _context;

		public AgentService(DapperContext context)
		{
			_context = context;
		}
		public async Task<int> GetAgentCount()
		{
			string query = "Select Count(*) From TblAgent";
			var connection = _context.CreateConnection();
			int value = await connection.QueryFirstOrDefaultAsync<int>(query);
			return value;
		}

		public async Task<List<ResultAgentDto>> GetAllAgentAsync()
		{
			string query = "Select * From TblAgent";
			var connection = _context.CreateConnection();
			var values = await connection.QueryAsync<ResultAgentDto>(query);
			return values.ToList();
		}
	}
}
