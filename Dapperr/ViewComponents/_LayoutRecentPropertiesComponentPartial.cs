using Dapperr.Services.PropertyService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutRecentPropertiesComponentPartial:ViewComponent
    {
		private readonly IPropertyService _propertyService;

		public _LayoutRecentPropertiesComponentPartial(IPropertyService propertyService)
		{
			_propertyService = propertyService;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
            var values=await _propertyService.GetRecentPropertiesList();
			return View(values);
        }
    }
}
