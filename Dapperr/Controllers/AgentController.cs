using Dapperr.Services.AgentService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
	public class AgentController : Controller
	{
		private readonly IAgentService _agentService;

		public AgentController(IAgentService agentService)
		{
			_agentService = agentService;
		}

		public async Task<IActionResult> AgentList()
		{
			var values = await _agentService.GetAllAgentAsync();
			return View(values);
		}
	}
}
