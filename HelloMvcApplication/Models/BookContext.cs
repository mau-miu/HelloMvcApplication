﻿

using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using HelloMvcApplication.Models;

namespace HelloMvcApplication.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookContext")
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}