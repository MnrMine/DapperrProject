using Dapperr.Dtos.AgentDto;
using Dapperr.Dtos.CategoryDtos;
using Dapperr.Dtos.ProductDtos;
using Dapperr.Services.AgentService;
using Dapperr.Services.PropertyService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AgentController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IAgentService _agentService;

        public AgentController(IPropertyService propertyService,IAgentService agentService)
        {
            _propertyService = propertyService;
            _agentService = agentService;
        }


        public async Task<IActionResult> AgentList()
        {
            var values = await _agentService.GetAllAgentAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAgent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAgent(CreateAgentDto createAgentDto)
        {
            await _agentService.CreateAgentAsync(createAgentDto);
            return RedirectToAction("AgentList");
        }
        public async Task<IActionResult> DeleteAgent(int id)
        {
            await _agentService.DeleteAgentAsync(id);
            return RedirectToAction("AgentList");
        }
        public async Task<IActionResult> UpdateAgent(int id)
        {
            var value = await _agentService.GetAllAgentAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAgent(UpdateAgentDto updateAgentDto)
        {
            await _agentService.UpdateAgentAsync(updateAgentDto);
            return RedirectToAction("AgentList");
        }
    }
}
