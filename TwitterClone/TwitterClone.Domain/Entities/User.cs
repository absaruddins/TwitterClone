
namespace TwitterClone.Domain.Entities
{
    //using inherite ,child class User from parent class BaseEntity
    public class User : BaseEntity, IFollowable,INotifiable
    {
        //constructor chianing
        public User() : base(Guid.NewGuid())
        {

        }
       
        private string _firstName;
        private string _lastName;
        private string _email;

       
       
        
       
        public string FirstName
        {
            get { return _firstName ; }
            set { _firstName = value ; }
        }
        public string LastName
        {
            get { return _lastName ; }
            set { _lastName = value ; }

        }
        public string Email { get;set }

        private List<Guid>_followers = new List<Guid>();

        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }

        }
        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

    }
}
