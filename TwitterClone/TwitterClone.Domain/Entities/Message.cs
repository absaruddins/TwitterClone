using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
       
        private Guid _userId;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;
       

        public Message() : base(Guid.NewGuid())
        {
           
            
        }
     
        public Guid UserId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public Guid ReceiverId { get; set; }
       
        public bool IsRead { get; }
    }
}
