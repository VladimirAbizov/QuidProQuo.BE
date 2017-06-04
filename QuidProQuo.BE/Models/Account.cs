using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Profile Profile { get; set; }
        
        public Account() { }
    }
}