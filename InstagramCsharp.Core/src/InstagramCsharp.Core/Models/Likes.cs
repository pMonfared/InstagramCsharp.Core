using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
    public class Likes
    {
        public int Count { get; set; }
        public List<User> Data { get; set; }
    }
}
