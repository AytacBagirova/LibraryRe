using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;
using Services.Model.Response;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class BookService : IBookService
    {
        public readonly IBookRepository bookRepository;
        public readonly RepositoryContext repositoryContext;
        List<BookResponse> response = new List<BookResponse>();

        public BookService(IBookRepository bookRepository, RepositoryContext repositoryContext)
        {
            this.bookRepository = bookRepository;
            this.repositoryContext = repositoryContext;
        }

        public List<BookResponse> GetAllBooks()
        {
            bookRepository.GetAll().ToList().ForEach(p => response.Add(new BookResponse
            {
                AdditionDate = p.AdditionDate,
                AuthorId = p.AuthorId,
                BookName = p.BookName,
                CategoryId = p.CategoryId,
                LanguageId = p.LanguageId
            }));

            return response;
        }

        public List<BookResponse> GetAllBooksWithJoin()
        {
            var list = repositoryContext.Books.ToList();

            response = list.Join(repositoryContext.Authors, b => b.AuthorId, a => a.Id, (a, b) => new { a, b })
                .Join(repositoryContext.Categories, b => b.a.CategoryId, d => d.Id, (l, d) => new { l, d })
                .Join(repositoryContext.Languages, l => l.l.a.LanguageId, k => k.Id, (r, k) => new BookResponse
                {
                    Id = r.l.a.Id,
                    AuthorId = r.l.a.AuthorId,
                    BookName = r.l.a.BookName,
                    CategoryId = r.l.a.Id,
                    LanguageId = k.Id
                    // Diğer özellikleri buraya ekleyin
                }).ToList();

            return response;
        }
    }
}
