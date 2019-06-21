using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFlower.Models
{
    public class Member
    {
        public String memberID { get; set; }

        public String memberName { get; set; }

        public String email { get; set; }

        public String password { get; set; }

        public String gender { get; set; }

        public int memberRole { get; set; }
    }
}