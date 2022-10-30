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
