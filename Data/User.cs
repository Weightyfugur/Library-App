using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class User
    {
        //card num validtion goes here
        public string Id { get; set; }

        public string Password {get; set; }

        //name validation goes here
        [Required]
        public string FirstName { get; set; }

        //name validation goes here
        [Required]
        public string LastName { get; set; }

        [Required]
        //[EmailValidation(ErrorMessage = "Email must be in the form: name@example.com")]
        public string Email { get; set; }

        //phone num validation goes here
        public string PhoneNumber {get; set; }

        public int BooksCheckedOut { get; set; } = 0;

        public int FeesOwed {get; set; } = 0;
    }
}
