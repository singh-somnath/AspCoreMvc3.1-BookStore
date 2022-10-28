using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Empployee_Management.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
         public string GetBook(int id)
        {
            return $"Book with id - {id}";
        }

        public string SearchBook(string bookName, string authorName)
        {
            return $"Book witk Name = {bookName} and Author={authorName}";
        }
    }
}
