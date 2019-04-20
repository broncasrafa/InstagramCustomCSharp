using Instagram.Core.Classes;

namespace Instagram.Core.API.Builder
{
    public interface IInstagramCustomApiBuilder
    {
        IInstagramCustomApi Build();
        IInstagramCustomApiBuilder SetUser(UserSessionData user);
    }
}
