using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>                                                                      
        public string Description { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public virtual CategoryItem CategoryItem { get; set; }
    }
}