using Dapperr.Services.LocationService;
using Dapperr.Services.PropertyService;
using Dapperr.Services.PropertyTypeService;
using Dapperr.Services.StatusService;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;

namespace Dapperr.Controllers
{
	public class PropertyController : Controller
	{
        private readonly IPropertyService _propertyService;
        private readonly ILocationService _locationService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IStatusService _statusService;

        public PropertyController(IPropertyService propertyService, ILocationService locationService, IPropertyTypeService propertyTypeService, IStatusService statusService)
        {
            _propertyService = propertyService;
            _locationService = locationService;
            _propertyTypeService = propertyTypeService;
            _statusService = statusService;
        }
        public  async Task<IActionResult> PropertyList(int page = 1)
		{
            var values = await _propertyService.GetAllPropertyAsync();
            return View(values.ToPagedList(page, 3));
            
		}

        public async Task<IActionResult> PropertyDetail(int id)
        {

            var value = await _propertyService.GetPropertyAsync(id);
            return View(value);
        }
    }
}
