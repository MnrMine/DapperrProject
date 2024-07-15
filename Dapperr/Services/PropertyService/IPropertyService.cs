using Dapperr.Dtos.PropertyDto;

namespace Dapperr.Services.PropertyService
{
    public interface IPropertyService
    {
		Task CreatePropertyAsync(CreatePropertyDto createPropertyDto);
		Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto);
		Task DeletePropertyAsync(int id);
		Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id);
		Task<List<ResultPropertyDto>> GetRecentPropertiesList();

	}
}
