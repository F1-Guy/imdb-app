using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class DeleteTitleModel : PageModel
    {
        readonly private IService service;

        public DeleteTitleModel(IService service)
        {
            this.service = service;
        }

        public IActionResult OnGet(string tconst)
        {
            service.DeleteTitle(tconst);
            return RedirectToPage("/Titles");
        }
    }
}
