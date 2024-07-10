using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutMostRecommendedPropertiesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
