namespace imdb_app.Services
{
    public interface IService
    {
        List<Title> GetTopAmountTitles(int amount);

        List<Name> GetTopAmountNames(int amount);
    }
}
