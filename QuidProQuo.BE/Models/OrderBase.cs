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
    public abstract class OrderBase : IEquatable<OrderBase>
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

        public bool Equals(OrderBase other)
        {
            //Check whether the compared object is null. 
            if (ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data. 
            if (ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal. 
            return Id.Equals(other.Id) && DateTime.Equals(other.DateTime) && ObjectBase.Equals(other.ObjectBase);
        }

        public override int GetHashCode()
        {
            //Get hash code for the Id field. 
            int hashOrderBaseCode = Id.GetHashCode();

            //Get hash code for the ObjectBase field if it is not null. 
            int hashOrderBaseObjectBase = ObjectBase == null ? 0 : ObjectBase.GetHashCode();

            //Get hash code for the DateTime field if it is not null. 
            int hashOrderBaseDateTime = DateTime == null ? 0 : DateTime.GetHashCode();
            
            //Calculate the hash code for the product. 
            return hashOrderBaseDateTime ^ hashOrderBaseCode ^ hashOrderBaseObjectBase;
        }
    }
}