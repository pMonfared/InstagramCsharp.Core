using System;
namespace InstagramCSharp.Core.Models
{
    [Obsolete("UserBasicInfo class is deprecated, please use Envelope<User> instead.")]
    public class UserBasicInfo : Envelope<User>
    {
    }
}
