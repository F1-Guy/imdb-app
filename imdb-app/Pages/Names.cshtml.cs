using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class NamesModel : PageModel
    {
        private readonly IService service;

        public NamesModel(IService service)
        {
            this.service = service;
        }

        [BindProperty(SupportsGet = true)]
        public int Amount { get; set; } = 10;

        public List<Name>? Names { get; set; }

        public void OnGet()
        {
            Names = service.GetTopAmountNames(Amount);
        }
    }
}
