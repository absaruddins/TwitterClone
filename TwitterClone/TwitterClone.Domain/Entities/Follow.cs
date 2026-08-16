using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _followedAt;

        public Follow()
        {
            _id = Guid.NewGuid();

        }
        public Guid FollowerId { get; set; }
        public DateTime FollowedAt { get; set; }
        public Guid followingId { get; set; }
    }
}
