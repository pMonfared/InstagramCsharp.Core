using System;
using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
    [Obsolete("FollowsFeed class is deprecated, please use Envelope<List<User>> instead.")]
    public class FollowsFeed : Envelope<List<User>>
    {
    }
}
