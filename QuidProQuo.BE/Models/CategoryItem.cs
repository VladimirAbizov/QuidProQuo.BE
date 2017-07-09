using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Содержит информацию о категориях вещей или услуг
    /// </summary>
    public class CategoryItem
    {  
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Заголовок категории
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Список подкатегорий, относящихся к данной категории
        /// </summary>
        public List<CategoryItem> Subcategories { get; set; }

        /// <summary>
        /// Объект <seealso cref="Models.CategoryType"/>, помечающий категорию как категорию вещей или услуг
        /// </summary>
        public CategoryType CategoryType { get; set; }

        /// <summary>
        /// Флаг, разъединяющий категории и подкатегории. Если флаг равен true, значит это категория, если false - значит подкатегория.
        /// </summary>
        public bool IsCategory { get; set; }
    }
}