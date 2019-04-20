using Instagram.Core.Classes.Interfaces;
using Instagram.Entity;

namespace Instagram.Core.API.Services.Interfaces
{
    public interface ISearchService
    {
        IResult<Search> Search(string query);
    }
}
