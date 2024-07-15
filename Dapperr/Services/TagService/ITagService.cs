using Dapperr.Dtos.TagDto;

namespace Dapperr.Services.TagService
{
    public interface ITagService
    {
		Task<List<ResultTagDto>> GetAllTagAsync();
	}
}
