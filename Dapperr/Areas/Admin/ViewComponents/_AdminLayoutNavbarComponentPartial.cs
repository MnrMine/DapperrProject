using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.ViewComponents
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
