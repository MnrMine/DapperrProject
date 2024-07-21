using Dapperr.Services.TagService;
using Microsoft.AspNetCore.Mvc;

namespace Dapperr.ViewComponents
{
    public class _TagCloudComponentPartial:ViewComponent
    {
        private readonly ITagService _tagService;

        public _TagCloudComponentPartial(ITagService tagService)
        {
            _tagService = tagService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tagService.GetAllTagAsync();
            return View(values);
        }
    }
}
