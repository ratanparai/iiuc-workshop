using System;
using System.Collections.Generic;
using Server.Domain;

namespace Server.Repository
{
    public class InMemoryDatabase
    {
        public InMemoryDatabase()
        {
            StatusMessages = new List<StatusMessage>();

            var ratanStatusOne = new StatusMessage(
                Guid.NewGuid(),
                "Ratan", 
                "Today I am gonna talk about web application");

            StatusMessages.Add(ratanStatusOne);
        }
        
        public List<StatusMessage> StatusMessages { get; set; }
    }
}