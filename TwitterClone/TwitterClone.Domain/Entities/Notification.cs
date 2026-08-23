using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    //abstract,use korle Notificatin er object create korte parbona ,er kono child override chada access pabena
    public abstract class Notification : BaseEntity
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
        //eta holo nonabstract ,abstract class nonabstract and abstract method raktepari
        //common data gola nonabstract rakbo
        public string GetNotificationInfo()
        {
            return $"UserId: {_userId}, NotificationType: {_type}";
        } 
        //virtual using for override
        //virtual ke abstract dia define korle ,child class method  override korte hobe
        //absract er kono body nai
        public abstract string GetMessage();
      

    }
}
