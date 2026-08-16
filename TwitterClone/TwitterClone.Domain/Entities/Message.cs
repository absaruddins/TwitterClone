using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _userId;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private bool _isRead;
        private DateTime _createdAt;

        public Message()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
            _isRead = false;
        }
        public Guid Id { get; }
        public Guid UserId { get; set; }
        public Guid SenderId { get; set; }
        public string Content { get; set; }
        public Guid ReceiverId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; }
    }
}
