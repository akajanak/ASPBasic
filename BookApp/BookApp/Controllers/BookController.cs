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
            return View();
        }
        public BookModel GetBook(int id)                                                 
        {
            return _bookRepository.GetBooksById(id);
        }
        public List<BookModel> SearchBook(string authorName, string bookName)
        {
            return _bookRepository.SearchBook(authorName, bookName);
        }
    }
}
