using Instagram.Core.Classes.Interfaces;
using Instagram.Entity;

namespace Instagram.Core.API.Services.Interfaces
{
    public interface IActionsService
    {
        IResult<string> Like(string mediaId);
        IResult<string> Unlike(string mediaId);
        IResult<string> RequestDownloadDataInformation(string email);
        IResult<string> Follow(string userId);
        IResult<string> Unfollow(string userId);
        IResult<CommentResponse> Comment(string mediaId, string text);
        IResult<string> DeleteComment(string mediaId, string commentId);
        IResult<string> LikeComment(string commentId);
        IResult<string> UnlikeComment(string commentId);
        IResult<string> SaveMedia(string mediaId);
        IResult<string> UnsaveMedia(string mediaId);
        IResult<CommentResponse> ReplyComment(string mediaId, string comment_id, string text);
        IResult<string> DeleteReplyComment(string mediaId, string repliedId);
    }
}
