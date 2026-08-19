
namespace TwitterClone.Domain.Entities
{
    //using inherite ,child class User from parent class BaseEntity
    public class User : BaseEntity
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
      
    }
}
