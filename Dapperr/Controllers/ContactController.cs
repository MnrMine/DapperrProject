using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
