
using Entities.Constract;

namespace Entities
{
    public  class User:IEntity
    {
        public int ID { get; set; }

        public string FIRSTNAME { get; set; }

        public string LASTNAME { get; set; }

        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int USERTYPEID { get; set; }

        public UserType? UserType { get; set; }
        // IEntity arabirimini uygulayın
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

    }
}
