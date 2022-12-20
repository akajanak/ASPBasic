using BookApp.Models;
using BookApp.Repository;
using Microsoft.AspNetCore.Mvc;


namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null ;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data =  _bookRepository.GetAllBooks();
            return View(data);
        }
        [Route("book-details/{id}", Name = "bookDetailsRoute")]
        public ViewResult GetBook(int id)                                                 
        {
            var data = _bookRepository.GetBooksById(id);
            return View(data);
        }
        public List<BookModel> SearchBook(string authorName, string bookName)
        {
            return _bookRepository.SearchBook(authorName, bookName);
        }

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.isSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel, int bookId = 0)
        {
            int id =await _bookRepository.AddNewBook(bookModel);
            if (id > 0)
            {
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true });
            }
            return View();
        }
    }
}
