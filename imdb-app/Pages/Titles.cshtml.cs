using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace imdb_app.Pages
{
    public class TitlesModel : PageModel
    {
        private readonly IService service;

        public TitlesModel(IService service)
        {
            this.service = service;
        }

        [BindProperty(SupportsGet = true)]
        public int Amount { get; set; } = 10;

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }

        public List<Title> Titles { get; set; }

        public void OnGet()
        {
            if (String.IsNullOrEmpty(Criteria))
            {
                Titles = service.GetTopAmountTitles(Amount);
            }
            else
            {
                Titles = service.WildcardSearchTitles(Criteria);
            }
        }
    }
}
