using System;
using System.Collections.Generic;

namespace Client.Domain
{
    public class StatusMessage
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public List<Like> Likes { get; set; } = new List<Like>();

        public int LikeCount { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public int CommentCount { get; set; }

    }
}