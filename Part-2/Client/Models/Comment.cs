using System;

namespace Client.Domain
{
    public class Comment
        : Person
    {
        public string CommentText { get; set; }
    }
}