using System;

namespace Server.Domain
{
    public class Comment
        : Person
    {
        public string CommentText { get; set; }
    }
}