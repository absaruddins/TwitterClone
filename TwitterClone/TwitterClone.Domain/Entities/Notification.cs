using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
       
        private Guid _userId;
        private string _type;
        private bool _isRead;
        private string _massage;
        
        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            _type = notificationType;
    
        }
       
        public Guid UserId { get; set; }
        public String Type { get; set; }
        public bool IsRead { get; set; }
        //protected mean, ei massage ter child access korte parbe
        protected string Message { get; set; }
       
    }
}
