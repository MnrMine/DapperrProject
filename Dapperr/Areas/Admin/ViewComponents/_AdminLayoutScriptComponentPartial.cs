using Microsoft.AspNetCore.Mvc;

namespace Dapperr.Areas.Admin.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
