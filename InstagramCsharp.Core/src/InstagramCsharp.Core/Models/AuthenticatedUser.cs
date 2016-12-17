namespace InstagramCSharp.Core.Models
{
    public class AuthenticatedUser
    {
        public string access_token { get; set; }
        public User user { get; set; }
    }
}
