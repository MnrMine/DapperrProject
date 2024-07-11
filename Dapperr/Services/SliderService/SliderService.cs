using Dapper;
using Dapperr.Context;
using Dapperr.Dtos.SliderDto;

namespace Dapperr.Services.SliderService
{
    public class SliderService : ISliderService
    {
        private readonly DapperContext _context;

        public SliderService(DapperContext context)
        {
            _context = context;
        }
        public Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSliderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            string query = "Select * From TblSlider";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultSliderDto>(query);
            return values.ToList();
        }

        public Task<GetByIdSliderDto> GetSliderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            throw new NotImplementedException();
        }
    }
}
