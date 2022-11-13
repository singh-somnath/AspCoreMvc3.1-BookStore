using Empployee_Management.Data;
using Empployee_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empployee_Management.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _bookStoreContext = null;

        public BookRepository(BookStoreContext _context)
        {
            _bookStoreContext = _context;
        }

        public async Task<int> AddNewBook(BookModel book)
        {
            Book newBook = new Book()
            {
                Author = book.Author,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow,
                Title = book.Title,
                TotalPages = book.TotalPages,
                Description = book.Description
            };

            await _bookStoreContext.AddAsync(newBook);
            await _bookStoreContext.SaveChangesAsync();

            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            List<BookModel> books = new List<BookModel>();
            var allBooks = await _bookStoreContext.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach (var book in allBooks)
                {

                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Category = book.Category,
                        Id = book.Id,
                        Description = book.Description,
                        Language = book.Language,
                        Title = book.Title,
                        CreatedOn = book.CreatedOn,
                        TotalPages = book.TotalPages,
                        UpdatedOn = book.UpdatedOn

                    });
                }
            }
            return books;
        }
        public async Task<BookModel> GetBookById(int bookId)
        {
            var book = await _bookStoreContext.Books.Where(x => x.Id == bookId).FirstOrDefaultAsync();

            if (book != null)
            {
                BookModel bookDetails = new BookModel()
                {
                    Title = book.Title,
                    Id = book.Id,
                    Language = book.Language,
                    TotalPages = book.TotalPages,
                    UpdatedOn = book.UpdatedOn,
                    CreatedOn = book.CreatedOn,
                    Category = book.Category,
                    Author = book.Author,
                    Description = book.Description

                };

                return bookDetails;
            }

            return null;
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>(){
               new BookModel(){Id=1, Title="MVC", Author="S Singh", Description = "This is description for book MVC", Category="MVC", TotalPages=1007, Language="English" },
               new BookModel(){Id=2, Title="C#", Author="Sohan Kumar",Description = "This is description for book C#", Category="Programming", TotalPages=107, Language="English" },
               new BookModel(){Id=3, Title="Pyhton", Author="R Singh",Description = "This is description for book Python", Category="Programming", TotalPages=987, Language="English" },
               new BookModel(){Id=4, Title="Javascript", Author="S Das",Description = "This is description for book JavaScript", Category="Script", TotalPages=678, Language="English" },
               new BookModel(){Id=5, Title="HTML", Author="R Kishan",Description = "This is description for book HTML", Category="Html", TotalPages=987, Language="English" },
               new BookModel(){Id=6, Title="CSS", Author="L Pandey",Description = "This is description for book CSS", Category="Programming", TotalPages=1345, Language="English" },
               new BookModel(){Id=7, Title="Java", Author="R Kumar",Description = "This is description for book Java", Category="Programming", TotalPages=654, Language="English" }
            };
        }
    }
}
