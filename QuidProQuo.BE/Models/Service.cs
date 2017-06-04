using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public CategoryItem CategoryItem { get; set; }
    }
}