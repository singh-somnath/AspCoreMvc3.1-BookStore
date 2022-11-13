using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empployee_Management.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options)
        { }

        public DbSet<Book> Books { get; set; }

       /* Connectstring added in startup class under configureservice.
        * protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SqlServer=;Database=BookStore;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
       */
    }
}
