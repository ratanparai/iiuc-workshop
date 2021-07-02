using System;

namespace Server.Domain
{
    public class Like
    {
        public Like(string name)
        {
            Name = name;
            Time = DateTime.UtcNow;
        }

        public string Name { get; }

        public DateTime Time { get; }
    }
}