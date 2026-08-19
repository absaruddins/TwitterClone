using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
       
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;

        public Bookmark() : base(Guid.NewGuid())
        {
            
        }
      
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
      

    }
}
