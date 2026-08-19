using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        
        private Guid _userId;
       

        public Retweet() : base(Guid.NewGuid())
        {
            
        }
       
        public Guid UserId { get; set; }
        
    }

}

