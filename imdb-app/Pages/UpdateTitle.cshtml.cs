using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class UpdateTitleModel : PageModel
    {
        private readonly IService service;

        public UpdateTitleModel(IService service)
        {
            this.service = service;
        }

        [BindProperty(SupportsGet = true)]
        public Title Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Genres { get; set; }
        
        public void OnGet(string tconst)
        {
            Title = service.FindTitleByTconst(tconst);
            Genres = string.Join(", ", Title.Genres.Select(g => g.Genre1));
        }

        public IActionResult OnPost()
        {
            service.UpdateTitle(Title, Genres);
            return RedirectToPage("/Titles");
        }
    }
}
