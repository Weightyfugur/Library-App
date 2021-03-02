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
        public int NumCopies { get; set; } = 1;

        [Required]
        [StringLength(17, ErrorMessage = "ISBN too long (17 character limit).")]
        public string ISBN { get; set; }
    }
}
