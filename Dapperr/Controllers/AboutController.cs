using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
