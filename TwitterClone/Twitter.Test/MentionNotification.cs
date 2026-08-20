using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class MentionNotification : Notification
    {
        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;

        }

        public Guid MentionedByUserId { get; set; }
      
        //protected mean, ei massage ter child access korte parbe
      
        public override string DescribeRecord()

        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord},MentionedByUserId:{MentionedByUserId}";

        }
        public override string GetMessage()
        {
            return $"MentionNotification Id : {MentionedByUserId } send to your friend";
        }
        
    }
}
