using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
