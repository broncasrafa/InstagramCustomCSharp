using Instagram.Core.Classes.Interfaces;
using Instagram.Entity;

namespace Instagram.Core.API.Services.Interfaces
{
    public interface IMediaService
    {
        IResult<ShortcodeMedia> GetMediaInfoData(string shortcode);
        IResult<EdgeMediaToParentComment> GetMediaComments(string shortcode, string endCursor, int limitPerPage = 12);
        IResult<Comment> GetLikesFromComment(string comment_id, string endCursor = null, int limitPerPage = 48);
        IResult<Comment> GetCommentReplies(string comment_id, string endCursor = null, int limitPerPage = 48);
    }
}
