using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empployee_Management.Models;
using Empployee_Management.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Empployee_Management.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
         public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
