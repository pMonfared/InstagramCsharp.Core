﻿using System;
using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
    [Obsolete("SubscriptionsFeed class is deprecated, please use Envelope<List<Subscription>> instead.")]
    public class SubscriptionsFeed : Envelope<List<Subscription>>
    {
    }
}
