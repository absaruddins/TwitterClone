
namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;

        public User()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;

        }
        public Guid Id
        {
            get { return _id ; }
        }

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
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value ; }


        }
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value  ; }

        }
        private Guid CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value ; }
        }
        private Guid ModifieddBy
        {
            get { return _modifiedBy; }
            set { _modifiedBy = value; }
        }
    }
}
