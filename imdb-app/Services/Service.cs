global using imdb_app.Models;
using Microsoft.EntityFrameworkCore;

namespace imdb_app.Services
{
    // One service to rule them all
    public class Service : IService
    {
        private readonly imdbContext context;

        public Service(imdbContext service)
        {
            context = service;
        }

        public List<Title> GetTopAmountTitles(int amount)
        {
            return context.Titles.Include(t => t.Genres).Take(amount).OrderByDescending(t=> t.Tconst).ToList();
        }

        public List<Title> WildcardSearchTitles(string criteria)
        {
            Task<List<findTitleResult>> task = context.Procedures.findTitleAsync(criteria);
            task.Wait();
            var resultList = task.Result;

            List<Title> list = TransformItems<findTitleResult, Title>(
                resultList, t => new Title
                {
                    Tconst = t.tconst,
                    TitleType = t.titleType,
                    PrimaryTitle = t.primaryTitle,
                    OriginalTitle = t.originalTitle,
                    IsAdult = t.isAdult,
                    StartYear = t.startYear,
                    EndYear = t.endYear,
                    RuntimeMinutes = t.runtimeMinutes
                });
                
            return list;
        }

        public void AddTitle(Title title, string genres)
        {
            context.Procedures.addTitleAsync(
                title.TitleType,
                title.PrimaryTitle,
                title.OriginalTitle,
                title.IsAdult,
                title.StartYear,
                title.EndYear,
                title.RuntimeMinutes,
                genres);
        }

        public List<Name> GetTopAmountNames(int amount)
        {
            return context.Names.Include(n => n.Professions).OrderByDescending(n => n.Nconst).Take(amount).ToList();
        }

        public List<Name> WildcardSearchNames(string criteria)
        {
            Task<List<findNameResult>> task = context.Procedures.findNameAsync(criteria);
            task.Wait();
            var resultList = task.Result;

            List<Name> list = TransformItems<findNameResult, Name>(
                resultList, n => new Name
                {
                    Nconst = n.nconst,
                    PrimaryName = n.primaryName,
                    BirthYear = n.birthYear,
                    DeathYear = n.deathYear
                });

            return list;
        }

        static List<V> TransformItems<T, V>(
        List<T> items, Func<T, V> transformer)
        {
            List<V> transformedItems = new List<V>();
            foreach (T item in items)
            {
                V transformedItem = transformer(item);
                transformedItems.Add(transformedItem);
            }
            return transformedItems;
        }
    }
}

