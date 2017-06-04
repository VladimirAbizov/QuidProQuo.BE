using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Описывает услугу
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название услуги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Категория, к которой относится данная услуга
        /// </summary>
        public CategoryItem CategoryItem { get; set; }
    }
}