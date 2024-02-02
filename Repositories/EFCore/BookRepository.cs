using Entities;
using Entities.Concretes;
using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class BookRepository: RepositoryManager<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
