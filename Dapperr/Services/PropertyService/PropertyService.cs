using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.PropertyDto;

namespace Dapperr.Services.PropertyService
{
	public class PropertyService : IPropertyService
	{
		private readonly DapperContext _dapperContext;

		public PropertyService(DapperContext dapperContext)
		{
			_dapperContext = dapperContext;
		}
		public Task CreatePropertyAsync(CreatePropertyDto createPropertyDto)
		{
			throw new NotImplementedException();
		}

		public Task DeletePropertyAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultPropertyDto>> GetRecentPropertiesList()
		{
			string query = "SELECT PropertyId,PropertyTitle,ImageUrl1,Price,SquareMeter,BedRooms,BathRooms,LocationName,TypeName,StatusName  FROM TblProperty INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.TypeId INNER JOIN  TblLocation ON TblProperty.LocationId = TblLocation.LocationId INNER JOIN   TblStatus ON TblProperty.StatusId = dbo.TblStatus.StatusId  Where IsFeatured =1";

			var connection = _dapperContext.CreateConnection();
			var values = await connection.QueryAsync<ResultPropertyDto>(query);
			return values.ToList();
		}

		public Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto)
		{
			throw new NotImplementedException();
		}
	}
}
