
using System.Runtime.InteropServices;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity,ILikeable
    {
   
        private Guid _userId;
        private string _content;

        

        //constructor chaining
        //complile time polymorphism constructors and  method,same class a hobe
        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }
        public Tweet(Guid userId, string content) : base(Guid.NewGuid())
        {
            _userId = userId;
            _content = content;
        }

        
        public Guid UserId { get; set; }
        public string Content { get; set; }
       //method
        public void AddContent(string content)
        {
            _content = content;
        }
        public void AddContent(Guid userId, string content)
        {
            _userId = userId;
            _content = content;
        }

        public bool CanBeLiked()
        {
            return true;
        }

    }
}
