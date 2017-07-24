﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidProQuo.BE.Models
{
    /// <summary>
    /// Объявление, в котором требуется вещь
    /// </summary>
    public class ThingOrder : OrderBase
    {
        /// <summary>
        /// Выставленная вещь
        /// </summary>
        public override ObjectBase objectBase
        {
            get { return base.objectBase; }
            set
            {
                if (value.GetType() == typeof(Thing))
                    base.objectBase = value;
            }
        }
    }
}