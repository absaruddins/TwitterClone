
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
   
        private Guid _userId;
        private string _content;
        //constructor chaining
        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

        public Guid UserId { get; set; }
        public string Content { get; set; }
       

        

    }
}
