using Dapperr.Services.AgentService;
using Dapperr.Services.LocationService;
using Dapperr.Services.PropertyService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutStatisticComponentPartial:ViewComponent
    {
        private readonly IPropertyService _propertyService;
        private readonly ILocationService _locationService;
        private readonly IAgentService _agentService;

        public _LayoutStatisticComponentPartial(IPropertyService propertyService, ILocationService locationService, IAgentService agentService)
        {
            _propertyService = propertyService;
            _locationService = locationService;
            _agentService = agentService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.propertyCount = await _propertyService.GetPropertyCount();
            ViewBag.locationCount = await _locationService.GetLocationCount();
            ViewBag.agentCount = await _agentService.GetAgentCount();
            ViewBag.propertyTypeCount = await _propertyService.GetPropertyTypeCount();
            return View();
        }
    }
}
