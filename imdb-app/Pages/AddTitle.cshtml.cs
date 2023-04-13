using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class AddTitleModel : PageModel
    {
        private readonly IService service;

        public AddTitleModel(IService service)
        {

            this.service = service;

        }

        [BindProperty]
        public Title Title { get; set; }

        [BindProperty]
        public string Genres { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            service.AddTitle(Title, Genres);
            return RedirectToPage("/Titles");
        }
    }
}
