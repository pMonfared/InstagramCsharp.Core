using System.Collections.Generic;

namespace InstagramCSharp.Core.Models
{
    public class Comments
    {
        public int Count { get; set; }
        public List<Comment> Data { get; set; }
    }
}
