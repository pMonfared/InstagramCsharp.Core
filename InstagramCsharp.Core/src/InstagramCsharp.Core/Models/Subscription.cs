﻿namespace InstagramCSharp.Core.Models
{
    public class Subscription
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string @object { get; set; }
        public string Aspect { get; set; }
        public string Callback_Url { get; set; }
        public string Object_Id { get; set; }
    }
}
