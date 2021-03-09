using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Data
{
    public class BookCount
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Status { get; set; }

        public int Count { get; set; }

        public BookCount(string title, string author, string isbn, string status, int c){
            Title = title;
            Author = author;
            ISBN = isbn;
            Status = status;
            Count = c;
        }
    }
}
