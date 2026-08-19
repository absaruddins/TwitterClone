using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
      
        private Guid _userId;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;

        public Follow() : base(Guid.NewGuid())
        {
        }
        public Guid UserId { get; set; }
        public Guid FollowerId { get; set; }
        public DateTime FollowedAt { get; set; }
        public Guid followingId { get; set; }
    }
}
