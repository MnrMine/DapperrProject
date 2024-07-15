using Dapperr.Dtos.AgentDto;

namespace Dapperr.Services.AgentService
{
    public interface IAgentService
    {
		Task<int> GetAgentCount();

		Task<List<ResultAgentDto>> GetAllAgentAsync();
	}
}
