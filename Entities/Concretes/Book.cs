using Entities.Constract;

namespace Entities.Concretes
{
    public class Book:IEntity
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public int LanguageId { get; set; }

        public DateTime AdditionDate { get; set; }

        public string BookName { get; set; }

        public Author Author { get; set; }

        public Category Category { get; set; }

        public Language Language { get; set; }
    }
}
