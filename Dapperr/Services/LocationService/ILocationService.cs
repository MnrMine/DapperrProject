using Dapperr.Dtos.LocationDto;

namespace Dapperr.Services.LocationService
{
    public interface ILocationService
    {
		Task<int> GetLocationCount();

		Task<List<ResultLocationDto>> GetAllLocationAsync();
	}
}
