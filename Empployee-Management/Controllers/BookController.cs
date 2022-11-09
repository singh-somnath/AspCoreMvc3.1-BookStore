using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empployee_Management.Data;
using Empployee_Management.Models;
using Empployee_Management.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Empployee_Management.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        [ViewData]
        public string Title { get; set; }
        public BookController(BookRepository bookRepository )
        {
            _bookRepository = bookRepository;
        }
        public ViewResult GetAllBooks()
        {
            Title = "Book List";
            List<BookModel> data =  _bookRepository.GetAllBooks();
            return View(data);
        }
         public ViewResult GetBook(int id)
        {
            
            var data =  _bookRepository.GetBookById(id);
            Title = "Book - " + data.Title;
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }

        public ViewResult AddNewBook(bool success = false, int bookID = 0)
        {
            ViewBag.IsSuccess = success;
            ViewBag.BookID = bookID;
            Title = "Add Book";
            return View();
        }
        [HttpPost]
        public IActionResult AddNewBook(BookModel bookModel)
        {
            int newBookId =_bookRepository.AddNewBook(bookModel);

            if (newBookId > 0)
            {
                return RedirectToAction("AddNewBook",new { success = true, bookID = newBookId });
            }
            return View();
        }
    }
}
