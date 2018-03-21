using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public int PostIds { get; set; }

        public Reply(int id, string content, int authorId, int postIds)
        {
            Id = id;
            Content = content;
            AuthorId = authorId;
            PostIds = postIds;
        }
    }
}
