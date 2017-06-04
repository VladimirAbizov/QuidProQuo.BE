using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuidProQuo.BE.Models
{
    public abstract class OrderBase
    {
        public int ID { get; set; }
        public string DateTime { get; set; }
    }
}