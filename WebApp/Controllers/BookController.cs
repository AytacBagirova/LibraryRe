using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Contracts;

namespace WebApp.Controllers
{
    public class BookController : Controller
    {
        public readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
                this.bookService=bookService;
        }

        [HttpGet]
        public IActionResult MyBorrowedBooks()
        {
            var borrowedBooks = bookService.GetAllBooks();
            return View(borrowedBooks);
        }

        public IActionResult MyBorrowedBook() 
        {
            return View();
        }
    }
}
