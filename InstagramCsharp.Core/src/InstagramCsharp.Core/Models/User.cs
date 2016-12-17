﻿namespace InstagramCSharp.Core.Models
{    
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Full_Name { get; set; }
        public string Profile_Picture { get; set; }
        public string Bio { get; set; }
        public string Website { get; set; }
        public UserCounts Counts { get; set; }
    }

}
