using Instagram.Core.Classes.Interfaces;
using Instagram.Entity;

namespace Instagram.Core.API.Services.Interfaces
{
    public interface IHashtagService
    {
        IResult<Hashtag> GetHashtag(string hashtag);
        IResult<EdgeHashtagToMedia> GetHashtagMedias(string hashtag, string endCursor, int limitPerPage = 12);
        IResult<ShortcodeHashtagMedia> GetShortcodeHashtagMedia(string shortcode);
    }
}
