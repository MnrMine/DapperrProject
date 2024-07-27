using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
