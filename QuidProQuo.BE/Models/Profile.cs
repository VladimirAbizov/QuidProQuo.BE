using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Account Account { get; set; }

        public List<OrderBase> Orders { get; set; }
    }
}