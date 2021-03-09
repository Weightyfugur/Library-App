using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [ISBNValidation(ErrorMessage = "ISBN must be 10 or 13 digits in the form: 1234567890 or 123-4567890123")]
        public string ISBN { get; set; }

        public string Status { get; set; } = "Coming Soon";
    }
}
