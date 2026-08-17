using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _userId;
      
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;
        public Like()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }
        public Guid Id { get; }
   

        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
       public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
