using BookApp.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }
        public BookModel GetBooksById(int id)
        {
            return DataSource().FirstOrDefault(x => x.Id == id);
        }

        public List<BookModel> SearchBook(string title, string authorName)
    {
        return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
    }
    private List<BookModel> DataSource()
    {
        return new List<BookModel>()
            {
              new BookModel(){Id=1, Title= "MVC", Author="Nitish"},
              new BookModel(){Id=2, Title= "Java", Author="Mohan"},
              new BookModel(){Id=3, Title= "Javascript", Author="Madan"},
              new BookModel(){Id=4, Title= "React", Author="Muna"},
              new BookModel(){Id=5, Title= "Angular", Author="Manish"},
            };
    }
}
}
