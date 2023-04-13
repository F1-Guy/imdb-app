namespace imdb_app.Services
{
    public interface IService
    {
        List<Title> GetTopAmountTitles(int amount);

        List<Title> WildcardSearchTitles(string criteria);

        List<Name> GetTopAmountNames(int amount);

        List<Name> WildcardSearchNames(string criteria);

        
    }
}
