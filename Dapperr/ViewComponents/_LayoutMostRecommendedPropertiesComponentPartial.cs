using Dapperr.Services.PropertyService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutMostRecommendedPropertiesComponentPartial:ViewComponent
    {
		private readonly IPropertyService _propertyService;

		public _LayoutMostRecommendedPropertiesComponentPartial(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _propertyService.GetLast4PropertyListAsync();

			return View(values);
        }
    }
}
