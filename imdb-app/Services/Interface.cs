namespace imdb_app.Services
{
    public interface IService
    {
        List<Title> GetTopAmountTitles(int amount);

        List<Title> WildcardSearchTitles(string criteria);

        Title FindTitleByTconst(string tconst);

        void AddTitle(Title titlem, string genres);

        void UpdateTitle(Title title, string genres);

        void DeleteTitle(string tconst);

        List<Name> GetTopAmountNames(int amount);

        List<Name> WildcardSearchNames(string criteria);

        void AddName(Name name, string professions);
        
    }
}
