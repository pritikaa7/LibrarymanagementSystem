using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystems.Models
{
    public class Member
    {
        public int MembershipId { get; set;}
        public string MemberName { get; set; }
        public string MemberAddress { get; set; }
        public int MemberContact { get; set; }
    }
}