﻿using System;
using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
     [Obsolete("CommentsFeed class is deprecated, please use Envelope<List<Comment>> instead.")]
    public class CommentsFeed : Envelope<List<Comment>>
    {
    }

}
