using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;

        public Bookmark()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }
        public Guid Id { get; }
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
