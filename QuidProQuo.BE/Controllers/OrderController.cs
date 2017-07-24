using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    public class OrderController : ApiController
    {
        public QpqContext _dbContext = new QpqContext();

        /// <summary>
        /// Возвращает список объявлений, найденых по названию
        /// </summary>
        /// <param name="item">Название</param>
        // GET api/order/anything
        public IEnumerable<OrderBase> Get(string item)
        {
            var orders = (from order in _dbContext.OrderBase
                          where order.objectBase.Title.Contains(item)
                          select order).ToList();
            return orders;
        }

        /// <summary>
        /// Возвращает список всех объявлений
        /// </summary>
        /// <returns></returns>
        // GET api/order
        public IEnumerable<OrderBase> Get()
        {
            return _dbContext.OrderBase.ToList();
        }
    }
}