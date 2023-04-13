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

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }

        public List<Name>? Names { get; set; }

        public void OnGet()
        {
            if (String.IsNullOrEmpty(Criteria))
            {
                Names = service.GetTopAmountNames(Amount);
            }
            else
            {
                Names = service.WildcardSearchNames(Criteria);
            }
        }
    }
}
