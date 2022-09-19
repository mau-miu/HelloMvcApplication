using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMvcApplication.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Autor { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}