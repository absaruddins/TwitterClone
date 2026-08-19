using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Live7
    {
        public void Run()
        {
            var likeNotification = new LikeNotification(Guid.NewGuid());
            var desicribe = likeNotification.DescribeRecord();
        }

        public void CreateCommentNotification()
        {
            var commentNotification = new CommentNotification();
        }
    }
}
