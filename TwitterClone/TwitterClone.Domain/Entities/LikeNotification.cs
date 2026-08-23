using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        //sealed, add kori public  er pore, LikeNotification ke inherite kora jabe na
        public LikeNotification(Guid likeByUserId) : base("Like")
        { 
            LikeByUserId = likeByUserId;
        }
        public Guid LikeByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }
        //eka override korsi
        public override string DescribeRecord()

        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikeByUserId: {LikeByUserId}";

        }
        public override string GetMessage()
        {
            return $"User with ID {LikeByUserId} liked your post";
        }
    }
}
