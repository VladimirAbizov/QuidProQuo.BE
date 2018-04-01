using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuidProQuo.BE.Models
{
    public interface IQpqContext : IDisposable
    {
       DbSet<OrderBase> OrderBases { get; }
       int SaveChanges();
       void MarkAsModified(OrderBase item);
    }
}
