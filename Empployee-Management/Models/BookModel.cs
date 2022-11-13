using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Empployee_Management.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Title of the book")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Book Title should be maximum 100 and minimum 10 charachters long.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Author of the book")]
        public string Author { get; set; }
        [StringLength(500, MinimumLength = 30, ErrorMessage = "Book Description should be maximum 500 and minimum 30 charachters long.")]
        public string Description { get; set; }

        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter Total Pages of the book")]
        [Display(Name = "Total Pages of Book")]
        public int? TotalPages { get; set; }
        public string Language { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
