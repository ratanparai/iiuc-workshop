using System;
using System.Collections.Generic;

namespace Server.Domain
{
    public class StatusMessage
    {
        public StatusMessage(Guid id, string name, string status)
        {
            Id = id;
            Name = name;
            Status = status;
        }

        public Guid Id { get; }

        public string Name { get; }

        public string Status { get; }

        public List<Like> Likes { get; } = new List<Like>();

        public int LikeCount { get; private set; }

        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public int CommentCount { get; private set; }

        public void Like(string name)
        {
            var like = new Like(name);

            Likes.Add(like);
            LikeCount++;
        }

        public void Comment(Comment comment)
        {
            Comments.Add(comment);
            CommentCount++;
        }

    }
}