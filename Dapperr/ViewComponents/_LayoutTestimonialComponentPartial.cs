using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _LayoutTestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
