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
        public ViewResult GetBook(int id)                                                 
        {
            var data = _bookRepository.GetBooksById(id);
            return View(data);
        }
        public List<BookModel> SearchBook(string authorName, string bookName)
        {
            return _bookRepository.SearchBook(authorName, bookName);
        }
        public ViewResult AddNewBook()
        {
            return View();
        }
    }
}
