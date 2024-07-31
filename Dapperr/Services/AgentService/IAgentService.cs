using Dapperr.Dtos.AgentDto;
using Dapperr.Dtos.PropertyDto;

namespace Dapperr.Services.AgentService
{
    public interface IAgentService
    {
		Task<int> GetAgentCount();

		Task<List<ResultAgentDto>> GetAllAgentAsync();
        Task<GetByIdAgentDto> GetAllAgentAsync(int id);
        Task CreateAgentAsync(CreateAgentDto createAgentDto);
        Task UpdateAgentAsync(UpdateAgentDto updateAgentDto);
        Task DeleteAgentAsync(int id);
    }
}
