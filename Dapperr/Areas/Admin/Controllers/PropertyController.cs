using Dapperr.Dtos.PropertyDto;
using Dapperr.Services.AgentService;
using Dapperr.Services.ImagesService;
using Dapperr.Services.LocationService;
using Dapperr.Services.PropertyService;
using Dapperr.Services.PropertyTypeService;
using Dapperr.Services.StatusService;
using Dapperr.Services.TagService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dapperr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IAgentService _agentService;
        private readonly ILocationService _locationService;
        private readonly IImagesService _imageService;
        private readonly IPropertyTypeService _propertyTypeService;
        private readonly IStatusService _statusService;
        private readonly ITagService _tagService;

        public PropertyController(IPropertyService propertyService, IAgentService agentService, ILocationService locationService, IImagesService imageService, IPropertyTypeService propertyTypeService, IStatusService statusService, ITagService tagService)
        {
            _propertyService = propertyService;
            _agentService = agentService;
            _locationService = locationService;
            _imageService = imageService;
            _propertyTypeService = propertyTypeService;
            _statusService = statusService;
            _tagService = tagService;
        }
        public async Task<IActionResult> PropertyList()
        {
            var values = await _propertyService.GetAllPropertyAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProperty()
        {
            List<SelectListItem> locationvalues = (from x in await _locationService.GetAllLocationAsync()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.LocationName,
                                                       Value = x.LocationId.ToString()
                                                   }).ToList();
            ViewBag.locations = locationvalues;

            List<SelectListItem> agentvalues = (from x in await _agentService.GetAllAgentAsync()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.AgentName,
                                                       Value = x.AgentId.ToString()
                                                   }).ToList();
            ViewBag.agents = agentvalues;

            List<SelectListItem> statusvalues = (from x in await _statusService.GetAllStatusAsync()
                                                select new SelectListItem
                                                {
                                                    Text = x.StatusName,
                                                    Value = x.StatusId.ToString()
                                                }).ToList();
            ViewBag.status = statusvalues;

            List<SelectListItem> propertyTypevalues = (from x in await _propertyTypeService.GetAllTypeAsync()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.TypeName,
                                                     Value = x.TypeId.ToString()
                                                 }).ToList();
            ViewBag.types = propertyTypevalues;

            List<SelectListItem> tagvalues = (from x in await _tagService.GetAllTagAsync()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.TagName,
                                                     Value = x.TagId.ToString()
                                                 }).ToList();
            ViewBag.tags = tagvalues;

            
            return View();
        }
		[HttpPost]
		public async Task<IActionResult> CreateProperty(CreatePropertyDto createPropertyDto)
		{
			createPropertyDto.Date = DateTime.Now;
			await _propertyService.CreatePropertyAsync(createPropertyDto);
			return RedirectToAction("PropertyList");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateProperty(int id)
		{
			
			var values = await _propertyService.GetAllPropertyAsync(id);
			return View(values);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateProperty(UpdatePropertyDto updatePropertyDto)
		{
			await _propertyService.UpdatePropertyAsync(updatePropertyDto);
			return RedirectToAction("PropertyList");
		}

        public async Task<IActionResult> DeleteProperty(int id)
        {
            await _propertyService.DeletePropertyAsync(id);
            return RedirectToAction("PropertyList");
        }
    }
}
