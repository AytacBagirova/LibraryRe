using Entities.Constract;

namespace Entities
{
    public class UserType:IEntity
    {
        public int Id { get; set; }

        public string? USERTYPENAME { get; set; }

        public List<User>? Users { get; set; }
    }
}
