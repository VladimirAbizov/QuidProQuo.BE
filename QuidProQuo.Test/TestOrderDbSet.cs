using System;
using System.Linq;
using QuidProQuo.BE.Models;

namespace QuidProQuo.Test
{
    class TestOrderDbSet : TestDbSet<OrderBase>
    {
        public override OrderBase Find(params object[] keyValues)
        {
            return this.SingleOrDefault(order => order.Id == (int)keyValues.Single());
        }
    }
}
