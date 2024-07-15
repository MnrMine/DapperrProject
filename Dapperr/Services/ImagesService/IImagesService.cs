using Dapperr.Dtos.ImagesDto;

namespace Dapperr.Services.ImagesService
{
	public interface IImagesService
	{
		Task<List<ResultImageDto>> GetAllImageAsync();
	}
}
