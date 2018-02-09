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
        /// Ключ генерируемый при входе в приложение, обладающий временем жизни <see cref="LifeTime"/>.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Время жизни ключа.
        /// </summary>
        public TimeSpan? LifeTime { get; set; }

        /// <summary>
        /// Объект класса <seealso cref="Models.Profile"/>, к которому привязан аккаунт
        /// </summary>
        public virtual Profile Profile { get; set; }
    }
}