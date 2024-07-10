using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
