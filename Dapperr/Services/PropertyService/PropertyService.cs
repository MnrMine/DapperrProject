using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.ProductDtos;
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
		public async Task CreatePropertyAsync(CreatePropertyDto createPropertyDto)
		{
            string query = "Insert Into TblProperty(PropertyTitle,ImageUrl,Description,Price,SquareMeter,BedRooms,BathRooms,Heating,Date,IsFeatured,ImagesId,Type_Id,LocationId,AgentId,StatusId,TagId,VideoUrl) values (@propertyTitle,@imageUrl,@description,@price,@squareMeter,@bedRooms,@bathRooms,@heating,@date,@isFeatured,@imagesId,@typeId,@locationId,@agentId,@statusId,@tagId,@videoUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyTitle", createPropertyDto.PropertyTitle);
            parameters.Add("@imageUrl", createPropertyDto.ImageUrl);
            parameters.Add("@description", createPropertyDto.Desciption);
            parameters.Add("@price", createPropertyDto.Price);
            parameters.Add("@squareMeter", createPropertyDto.SquareMeter);
            parameters.Add("@bedRooms", createPropertyDto.BedRooms);
            parameters.Add("@bathRooms", createPropertyDto.BathRooms);
            parameters.Add("@heating", createPropertyDto.Heating);
            parameters.Add("@date", createPropertyDto.Date);
            parameters.Add("@isFeatured", createPropertyDto.IsFeatured);
            parameters.Add("@imagesId", createPropertyDto.ImagesId);
            parameters.Add("@typeId", createPropertyDto.TypeId);
            parameters.Add("@locationId", createPropertyDto.LocationId);
            parameters.Add("@agentId", createPropertyDto.AgentId);
            parameters.Add("@statusId", createPropertyDto.StatusId);
            parameters.Add("@tagId", createPropertyDto.TagId);
            parameters.Add("@videoUrl", createPropertyDto.VideoUrl);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

		public async Task DeletePropertyAsync(int id)
		{
            string query = "Delete From TblProperty Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,StatusName,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.LocationId = TblProperty.LocationId INNER JOIN TblStatus ON TblProperty.StatusId = TblStatus.StatusId INNER JOIN  TblPropertyType ON TblProperty.Type_Id = TblPropertyType.TypeId";
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryAsync<ResultPropertyDto>(query);
            return values.ToList();
        }

        public async  Task<GetByIdPropertyDto> GetAllPropertyAsync(int id)
		{
            string query = "Select * From TblProperty Where PropertyId=@propertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            var connection = _dapperContext.CreateConnection();
            var values = await connection.QueryFirstOrDefaultAsync<GetByIdPropertyDto>(query, parameters);
            return values;
        }

		public async Task<List<ResultPropertyDto>> GetLast4PropertyListAsync()
		{
			string query = "SELECT top 4 PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BathRooms,BedRooms,LocationName,StatusName,TypeName FROM TblProperty INNER JOIN  TblLocation ON TblLocation.LocationId = TblProperty.LocationId INNER JOIN     TblStatus ON TblProperty.StatusId = TblStatus.StatusId INNER JOIN  TblPropertyType ON TblProperty.Type_Id = TblPropertyType.TypeId Order by PropertyId Desc";
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

        public async Task<int> GetPropertyCount()
        {
            string query = "Select Count(*) From TblProperty";
            var connection = _dapperContext.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<int> GetPropertyTypeCount()
        {
            string query = "Select Count(*) From TblPropertyType";
            var connection = _dapperContext.CreateConnection();
            int value = await connection.QueryFirstOrDefaultAsync<int>(query);
            return value;
        }

        public async Task<List<ResultPropertyDto>> GetRecentPropertiesList()
		{
			string query = "SELECT PropertyId,PropertyTitle,ImageUrl,Price,SquareMeter,BedRooms,BathRooms,LocationName,TypeName,StatusName  FROM TblProperty INNER JOIN  TblPropertyType ON TblProperty.Type_Id = TblPropertyType.TypeId INNER JOIN  TblLocation ON TblProperty.LocationId = TblLocation.LocationId INNER JOIN   TblStatus ON TblProperty.StatusId = dbo.TblStatus.StatusId  Where IsFeatured =1";

			var connection = _dapperContext.CreateConnection();
			var values = await connection.QueryAsync<ResultPropertyDto>(query);
			return values.ToList();
		}

		public async Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto)
		{
            string query = "Update TblProperty Set PropertyTitle=@p1,ImageUrl=@p2,Description=@p3,Price=@p4,SquareMeter=@p5,BedRooms=@p6,BathRooms=@p7,Heating=@p8,Date=@p9,IsFeatured=@p10,ImagesId=@p11,Type_Id=@p12,LocationId=@p13,AgentId=@p14,StatusId=@p15,TagId=@p16,VideoUrl=@p17  where PropertyId=@p18";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", updatePropertyDto.PropertyTitle);
            parameters.Add("@p2", updatePropertyDto.ImageUrl);
            parameters.Add("@p3", updatePropertyDto.Description);
            parameters.Add("@p4", updatePropertyDto.Price);
            parameters.Add("@p5", updatePropertyDto.SquareMeter);
            parameters.Add("@p6", updatePropertyDto.BedRooms);
            parameters.Add("@p7", updatePropertyDto.BathRooms);
            
            parameters.Add("@p8", updatePropertyDto.Heating);
            parameters.Add("@p9", updatePropertyDto.Date);
            parameters.Add("@p10", updatePropertyDto.IsFeatured);
            parameters.Add("@p11", updatePropertyDto.ImagesId);
            parameters.Add("@p12", updatePropertyDto.TypeId);
            parameters.Add("@p13", updatePropertyDto.LocationId);
            parameters.Add("@p14", updatePropertyDto.AgentId);
            parameters.Add("@p15", updatePropertyDto.StatusId);
            parameters.Add("@p16", updatePropertyDto.TagId);
            parameters.Add("@p17", updatePropertyDto.VideoUrl);
            parameters.Add("@p18", updatePropertyDto.PropertyId);
            var connection = _dapperContext.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }
	}
}
