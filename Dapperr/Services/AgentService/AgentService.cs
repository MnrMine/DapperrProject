using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.AgentDto;
using Dapperr.Dtos.PropertyDto;

namespace Dapperr.Services.AgentService
{
	public class AgentService : IAgentService
	{
		private readonly DapperContext _context;

		public AgentService(DapperContext context)
		{
			_context = context;
		}

        public async Task CreateAgentAsync(CreateAgentDto createAgentDto)
        {
            string query = "Insert Into TblAgent(AgentName,ImageUrl,Description) values (@agentName,@imageUrl,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@agentName", createAgentDto.AgentName);
            parameters.Add("@imageUrl", createAgentDto.ImageUrl);
            parameters.Add("@description", createAgentDto.Description);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeleteAgentAsync(int id)
        {
            string query = "Delete From TblAgent Where AgentId=@agentId";
            var parameters = new DynamicParameters();
            parameters.Add("@agentId", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
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

        public async Task<GetByIdAgentDto> GetAllAgentAsync(int id)
        {
            string query = "Select * From TblAgent Where AgentId=@agentId";
            var parameters = new DynamicParameters();
            parameters.Add("@agentId", id);
            var connection = _context.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIdAgentDto>(query, parameters);
            return values;
        }

        public async Task UpdateAgentAsync(UpdateAgentDto updateAgentDto)
        {
            string query = "Update TblAgent Set AgentName=@p1,ImageUrl=@p2,Description=@p3 where AgentId=@p18";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", updateAgentDto.AgentName);
            parameters.Add("@p2", updateAgentDto.ImageUrl);
            parameters.Add("@p3", updateAgentDto.Description);
            parameters.Add("@p4", updateAgentDto.AgentId);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
    }
}
