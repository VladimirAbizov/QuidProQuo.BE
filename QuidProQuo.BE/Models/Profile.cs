using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Содержит общую информацию об учетной записи пользователя
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Идентификатор профиля
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Адресс пользователя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефонный номер пользователя
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Адресс электронной почты пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Список объявлений, выставленных данным пользователем
        /// </summary>
        public virtual List<OrderBase> Orders { get; set; }
    }
}