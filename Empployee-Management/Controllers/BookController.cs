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
        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            Title = "Book List";
            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        public async Task<ViewResult> GetBook(int id)
        {

            var data = await _bookRepository.GetBookById(id);
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
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int newBookId = await _bookRepository.AddNewBook(bookModel);
                if (newBookId > 0)
                {
                    return RedirectToAction("AddNewBook", new { success = true, bookID = newBookId });
                }
            }
            return View();
        }
    }
}
