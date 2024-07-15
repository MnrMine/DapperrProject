using Dapperr.Dtos.TestimonialDto;

namespace Dapperr.Services.TestimonialService
{
    public interface ITestimonialService
    {
		Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
		Task CreateTestimonialAsync(CreateTestiomonialDto createTestimonialDto);
		Task DeleteTestimonialAsync(int id);
		Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
		Task<GetByIdTestimonialDto> GetTestimonialAsync(int id);
	}
}
