using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.ViewComponents
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
