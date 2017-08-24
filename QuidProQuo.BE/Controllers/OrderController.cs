using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Newtonsoft.Json;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    public class ActionData
    {
        public object[] orderFields { get; set; }    
    }
    public class OrderController : ApiController
    {
        public QpqContext _dbContext = new QpqContext();

        /// <summary>
        /// Возвращает список всех объявлений
        /// </summary>
        /// <returns></returns>
        // GET api/order
        public string Get()
        {
            var orders = _dbContext.OrderBase.ToList();

            return JsonConvert.SerializeObject(orders);
        }

        /// <summary>
        /// Возвращает список объявлений, найденых по названию
        /// </summary>
        /// <param name="item">Название</param>
        // GET api/order/anything
        public string Get(string item)
        {
            var orders = (from order in _dbContext.OrderBase
                          where order.objectBase.Title.Contains(item)
                          select order).ToList();
            return JsonConvert.SerializeObject(orders);
        }

        /// <summary>
        /// Добавляет объявление в базу данных
        /// </summary>
        /// <param name="actionData"></param>
        // POST api/order
        [HttpPost]
        public HttpResponseMessage Post(ActionData actionData)     //ошибка 500 из за объекта CategoryItem
        {
            if (actionData == null)
            {
               return new HttpResponseMessage(HttpStatusCode.Conflict);
            }
            var category = _dbContext.CategoryItems.Find(actionData.orderFields[3]);
            if(category == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            if (category.CategoryType == CategoryType.Thing)
                _dbContext.ThingOrders.Add(new ThingOrder
                {
                    DateTime = actionData.orderFields[0].ToString(),
                    objectBase = new Thing
                    {
                        Title = actionData.orderFields[1].ToString(),
                        Description = actionData.orderFields[2].ToString(),
                        CategoryItem = category
                    }
                });
            if(category.CategoryType == CategoryType.Service)
                _dbContext.ServiceOrders.Add(new ServiceOrder
                {
                    DateTime = actionData.orderFields[0].ToString(),
                    objectBase = new Service
                    {
                        Title = actionData.orderFields[1].ToString(),
                        Description = actionData.orderFields[2].ToString(),
                        CategoryItem = category
                    }
                });
            //_dbContext.ThingOrders.Add(actionData.order);

            //_dbContext.OrderBase.Add(actionData.order);
            _dbContext.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        /// <summary>
        /// Обновляет объявление в базе данных по идентификатору <see cref="OrderBase.ID"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        // PUT api/order/5
        public void Put(int id, [FromBody]OrderBase order)
        {
            if (id == order.ID)
            {
                _dbContext.Entry(order).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет объявление из базы данных по идентификатору <see cref="OrderBase.ID"/>
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/order/5
        public void Delete(int id)
        {
            OrderBase order = _dbContext.OrderBase.Find(id);
            if (order != null)
            {
                _dbContext.OrderBase.Remove(order);
                _dbContext.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
