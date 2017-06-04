using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Содержит системную информацию об учетной записи пользователя
    /// </summary>
    public class Account
    {
        /// <summary>
        ///  Идентификатор учетной записи пользователя
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        ///  Логин пользователя
        /// </summary>
        public string Login { get; set; }
        
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Объект класса <seealso cref="Models.Profile"/>, к которому привязан аккаунт
        /// </summary>
        public Profile Profile { get; set; }
    }
}