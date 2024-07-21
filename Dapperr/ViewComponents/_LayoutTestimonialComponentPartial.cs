using Dapperr.Services.TestimonialService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutTestimonialComponentPartial:ViewComponent
    {
		private readonly ITestimonialService _testimonialService;

		public _LayoutTestimonialComponentPartial(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
    }
}
