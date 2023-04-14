using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class AddNameModel : PageModel
    {
        private readonly IService service;

        public AddNameModel(IService service)
        {
            this.service = service;
        }

        [BindProperty]
        public Name Name { get; set; }

        [BindProperty]
        public string Professions { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            service.AddName(Name, Professions);
            return RedirectToPage("/Names");
        }
    }
}
