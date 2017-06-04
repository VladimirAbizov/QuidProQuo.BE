using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Описывает вещь
    /// </summary>
    public class Thing
    {
        /// <summary>
        /// Идентификатор вещи
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название вещи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Категория, к которой относится данная вещь
        /// </summary>
        public CategoryItem CategoryItem { get; set; }
    }
}