using Dapperr.Dtos.PropertyDto;

namespace Dapperr.Services.PropertyService
{
    public interface IPropertyService
    {
        Task<List<ResultPropertyDto>> GetAllPropertyAsync();
        Task CreatePropertyAsync(CreatePropertyDto createPropertyDto);
		Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto);
		Task DeletePropertyAsync(int id);
		Task<GetByIdPropertyDto> GetAllPropertyAsync(int id);
		Task<List<ResultPropertyDto>> GetRecentPropertiesList();
		Task<List<ResultPropertyDto>> GetLast4PropertyListAsync();
        Task<GetByIdPropertyDto> GetPropertyAsync(int id);
        Task<int> GetPropertyCount();
        Task<int> GetPropertyTypeCount();

    }
}
