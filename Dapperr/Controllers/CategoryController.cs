using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
