using Entities.Constract;

namespace Entities.Concretes
{
    public class Language:IEntity
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }

        public List<Book> Books { get; set; }
    }
}
