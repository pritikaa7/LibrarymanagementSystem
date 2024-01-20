using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystems.Models
{
    public class Book
    {
        public int Bookid { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookRentalCost { get; set; }
    }
}