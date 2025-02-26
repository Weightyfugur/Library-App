﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryApp.Data
{
    public class LibraryDBContext : IdentityDbContext
    {
        
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options) : base(options)
        {

        }


        // makes table called 'Books'. Data will be passed into class 'Book'
        public DbSet<Book> Books {get; set; }


    }
}

