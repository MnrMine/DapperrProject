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

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,StatusName,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.LocationId = TblProperty.LocationId INNER JOIN TblStatus ON TblProperty.StatusId = TblStatus.StatusId INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.TypeId";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyDto>(query);
            return values.ToList();
        }

        public Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultPropertyDto>> GetLast4PropertyListAsync()
		{
			string query = "SELECT top 4 PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,StatusName,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.LocationId = TblProperty.LocationId INNER JOIN     TblStatus ON TblProperty.StatusId = TblStatus.StatusId INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.TypeId Order by PropertyId Desc";
			var connection = _dapperContext.CreateConnection();
			var values = await connection.QueryAsync<ResultPropertyDto>(query);
			return values.ToList();
		}

        public async Task<GetByIdPropertyDto> GetPropertyAsync(int id)
        {
            string query = "Select PropertyId,PropertyTitle,Description,Images1, Images2, Images3, Images4, Images5,VideoUrl,ImageUrl,LocationName From TblProperty  Inner Join Tbl_Images On Tbl_Images.ImagesId = TblProperty.ImagesId INNER JOIN TblLocation On TblLocation.LocationId=TblProperty.LocationId Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query, parameters);
            return values;
        }

        public async Task<List<ResultPropertyDto>> GetRecentPropertiesList()
		{
			string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BedRooms,BathRooms,LocationName,TypeName,StatusName  FROM TblProperty INNER JOIN  TblPropertyType ON TblProperty.TypeId = TblPropertyType.TypeId INNER JOIN  TblLocation ON TblProperty.LocationId = TblLocation.LocationId INNER JOIN   TblStatus ON TblProperty.StatusId = dbo.TblStatus.StatusId  Where IsFeatured =1";

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
