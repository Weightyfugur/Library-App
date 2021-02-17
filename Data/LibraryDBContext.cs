using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class LibraryDBContext : DbContext
    {
        
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {

        }

        // makes table called 'Books'. Data will be passed into class 'Book'
        //public Dbset<Book> Books {get; set; }

    }
}


//public class Book
//{
//    // properties
//    int id;
//    string name;
    
//}

