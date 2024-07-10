using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutStatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
