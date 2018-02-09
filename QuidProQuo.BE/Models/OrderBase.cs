using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Абстрактный класс, содержащий общие поля для классов <seealso cref="Models.ServiceOrder"/> и <seealso cref="Models.ThingOrder"/>
    /// </summary>
    public abstract class OrderBase
    {
        /// <summary>
        /// Идентификатор объявления
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата регистрации объявления
        /// </summary>
        public string DateTime { get; set; }

        /// <summary>
        /// Прикрепленный к объявлению объект
        /// </summary>
        public virtual ObjectBase ObjectBase { get; set; }
    }
}