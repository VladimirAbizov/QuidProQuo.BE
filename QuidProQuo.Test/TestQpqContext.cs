using System;
using System.Data.Entity;
using QuidProQuo.BE.Models;

namespace QuidProQuo.Test
{
    public class TestQpqContext : IQpqContext
    {
        public TestQpqContext()
        {
            this.OrderBases = new TestOrderDbSet();
        }

        public DbSet<OrderBase> OrderBases { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(OrderBase item) { }
        public void Dispose() { }
    }
}
