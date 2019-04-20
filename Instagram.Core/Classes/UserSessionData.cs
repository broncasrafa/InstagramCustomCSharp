namespace Instagram.Core.Classes
{
    public class UserSessionData
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CsrfToken { get; set; }
        public string UserCookie { get; set; }
        public string UserRhxGis { get; set; }
    }
}
