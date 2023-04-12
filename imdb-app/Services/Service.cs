global using imdb_app.Models;
using Microsoft.EntityFrameworkCore;

namespace imdb_app.Services
{
    public class Service : IService
    {
        private readonly imdbContext context;

        public Service(imdbContext service)
        {
            context = service;
        }

        public List<Title> GetTopAmountTitles(int amount)
        {
            return context.Titles.Include(t => t.Genres).Take(amount).ToList();
        }

        //public List<Title> WildcardSearchTitles(string criteria)
        //{

        //}

        public List<Name> GetTopAmountNames(int amount)
        {
            return context.Names.Include(n => n.Professions).Take(amount).ToList();
        }

    }
}
