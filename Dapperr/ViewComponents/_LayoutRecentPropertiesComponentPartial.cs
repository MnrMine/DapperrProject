using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutRecentPropertiesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
