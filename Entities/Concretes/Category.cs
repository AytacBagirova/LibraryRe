using Entities.Constract;

namespace Entities.Concretes
{
    public class Category: IEntity
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Book> Books { get; set; }
    }
}
