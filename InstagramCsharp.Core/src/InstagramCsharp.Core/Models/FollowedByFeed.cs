﻿using System;
using System.Collections.Generic;
namespace InstagramCSharp.Core.Models
{
    [Obsolete("FollowedByFeed class is deprecated, please use Envelope<List<User>> instead.")]
    public class FollowedByFeed : Envelope<List<User>>
    {
    }
}
