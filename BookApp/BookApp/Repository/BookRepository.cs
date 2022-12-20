using BookApp.Data;
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
        private readonly BookStoreContext _context = null;
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                Title = model.Title,
                TotalPages = model.TotalPages,
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }
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
              new BookModel(){Id=1, Title= "MVC", Author="Nitish", Description="This is MVC Book", Category="programming", Language="english"},
              new BookModel(){Id=2, Title= "Java", Author="Mohan", Description="This is Java Book",  Category="programming", Language="english", CreatedOn= DateTime.UtcNow },
              new BookModel(){Id=3, Title= "Javascript", Author="Madan", Description = "This is JavaScript Book",  Category="programming", Language="english"},
              new BookModel(){Id=4, Title= "React", Author="Muna", Description = "This is React Book",  Category="Library", Language="english"},
              new BookModel(){Id=5, Title= "Angular", Author="Manish", Description = "This is Angular Book", Category="Framework", Language="english"},
            };
    }
}
}
