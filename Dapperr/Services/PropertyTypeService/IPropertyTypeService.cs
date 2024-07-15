using Dapperr.Dtos.PropertyTypeDto;

namespace Dapperr.Services.PropertyTypeService
{
	public interface IPropertyTypeService
	{
		Task<List<ResultPropertyTypeDto>> GetAllTypeAsync();
		//Task<List<GetCountPropertyType>> GetCountPropertyTypesAsync();
	}
}
