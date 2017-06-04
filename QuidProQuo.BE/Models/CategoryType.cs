using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Перечисление, используемое для пометки категорий как категорий вещей или услуг
    /// </summary>
    public enum CategoryType
    {
        Thing = 1,
        Service = 2
    }
}