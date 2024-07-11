using Dapperr.Dtos.SliderDto;

namespace Dapperr.Services.SliderService
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task DeleteSliderAsync(int id);
        Task UpdateSliderAsync(UpdateSliderDto updateSliderDto);
        Task<GetByIdSliderDto> GetSliderAsync(int id);
    }
}
