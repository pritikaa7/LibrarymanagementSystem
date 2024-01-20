using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystems.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminDetails { get; set; }
        public int AdminContact { get; set; }
    }
}