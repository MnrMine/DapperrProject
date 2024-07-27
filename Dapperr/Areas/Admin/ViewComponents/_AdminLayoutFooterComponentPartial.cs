using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.ViewComponents
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
