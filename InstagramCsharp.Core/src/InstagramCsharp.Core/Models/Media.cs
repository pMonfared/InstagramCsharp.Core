﻿using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
    public class Media
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Filter { get; set; }
        public long Created_Time { get; set; }
        public string Link { get; set; }
        public bool User_Has_Liked { get; set; }
        public Location Location { get; set; }
        public Comments Comments { get; set; }
        public Likes Likes { get; set; }
        public Images Images { get; set; }
        public Videos Videos { get; set; }
        public List<UserInPhoto> Users_In_Photo { get; set; }
        public List<string> Tags { get; set; }
        public Caption Caption { get; set; }
        public User User { get; set; }
    }

}
