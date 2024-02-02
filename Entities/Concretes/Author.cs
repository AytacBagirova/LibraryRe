using Entities.Constract;

namespace Entities.Concretes
{
    public class Author:IEntity
    {
        public int Id { get; set; }

        public string AUTHORNAME { get; set; }

        public string AUTHORSURNAME { get; set; }

        public List<Book> Authors { get; set; }
    }
}
