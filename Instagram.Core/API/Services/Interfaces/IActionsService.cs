using Instagram.Core.Classes.Interfaces;

namespace Instagram.Core.API.Services.Interfaces
{
    public interface IActionsService
    {
        IResult<string> Like(string mediaId);
        IResult<string> Unlike(string mediaId);
        IResult<string> RequestDownloadDataInformation(string email);
    }
}
