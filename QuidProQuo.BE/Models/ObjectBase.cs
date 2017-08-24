using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Абстрактный класс, содержащий общие поля для классов <seealso cref="Service"/> и <seealso cref="Thing"/>
    /// </summary>                       
    public abstract class ObjectBase
    {
        /// <summary>                                                    
        /// Идентификатор 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>                                                                      
        public string Description { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public CategoryItem CategoryItem { get; set; }
    }
}