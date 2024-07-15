using Dapperr.Dtos.StatusDto;

namespace Dapperr.Services.StatusService
{
	public interface IStatusService
	{
		Task<List<ResultStatusDto>> GetAllStatusAsync();
	}
}
