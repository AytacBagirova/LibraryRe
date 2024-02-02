using Services.Model.Response;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface IBookService
    {
        List<BookResponse> GetAllBooks();

        List<BookResponse> GetAllBooksWithJoin();
    }
}
