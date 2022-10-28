using Empployee_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empployee_Management.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int bookId)
        {
            return DataSource().Where(x => x.Id == bookId).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>(){
               new BookModel(){Id=1, Title="MVC", Author="S Singh" },
               new BookModel(){Id=2, Title="C#", Author="Sohan Kumar" },
               new BookModel(){Id=3, Title="Pyhton", Author="R Singh" },
               new BookModel(){Id=4, Title="Javascript", Author="S Das" },
               new BookModel(){Id=5, Title="HTML", Author="R Kishan" },
               new BookModel(){Id=6, Title="CSS", Author="L Pandey" },
               new BookModel(){Id=7, Title="Java", Author="R Kumar" }
            };
        }
    }
}
