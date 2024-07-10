using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
