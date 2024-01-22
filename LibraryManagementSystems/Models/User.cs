using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystems.Models
{
    public class User
    {
        public int userID { get; set; }

        public string  userName { get; set; }
        public string Password { get; set; }
    }
}