using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoryItem
    {  
        public int ID { get; set; }
        public string Title { get; set; }

        public List<CategoryItem> Subcategories { get; set; }

        public CategoryType CategoryType { get; set; }
    }
}