using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Newtonsoft.Json;
using QuidProQuo.BE.Attributes;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    public class ActionData
    {
        public object[] orderFields { get; set; }
    }

    [QAuthAtribute]
    public class OrderController : ApiController
    {
        private readonly QpqContext _dbContext = new QpqContext();

        // modify the type of the db field
        private IQpqContext db = new QpqContext();

        // add these contructors
        public OrderController() { }

        public OrderController(IQpqContext context)
        {
            db = context;
        }

        /// <summary>
        /// Возвращает список всех объявлений
        /// </summary>
        /// <returns></returns>
        // GET api/order
        public string Get()
        {
            var orders = _dbContext.OrderBases.Include(o => o.ObjectBase).ToList();

            return JsonConvert.SerializeObject(orders);
            //return orders;
        }

        /// <summary>
        /// Возвращает список объявлений, найденых по названию
        /// </summary>
        /// <param name="item">Название</param>
        // GET api/order/anything
        public string Get(string item)
        {
            var orders = (from order in _dbContext.OrderBases
                          where order.ObjectBase.Title.Contains(item)
                          select order).ToList();
            return JsonConvert.SerializeObject(orders);
        }

        /// <summary>
        /// Добавляет объявление в базу данных
        /// </summary>
        /// <param name="actionData"></param>
        /// <param name="id"></param>
        // POST api/order
        public HttpResponseMessage Post(ActionData actionData, int id)
        {
            if (actionData == null)
                return new HttpResponseMessage(HttpStatusCode.Conflict);

            var category = _dbContext.CategoryItems.Find(actionData.orderFields[3]);
            //var account = _dbContext.Accounts.Find(id);
            var profile = _dbContext.Profiles.Find(id);

            if(category == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            if (profile == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            if (category.categoryType == CategoryType.Thing)
                profile.Orders.Add(new ThingOrder
                {
                    DateTime = actionData.orderFields[0].ToString(),
                    ObjectBase = new Thing
                    {
                        Title = actionData.orderFields[1].ToString(),
                        Description = actionData.orderFields[2].ToString(),
                        CategoryItem = category,
                        Location = actionData.orderFields[4].ToString()
                    }
                });
            if (category.categoryType == CategoryType.Service)
                profile.Orders.Add(new ServiceOrder
                {
                    DateTime = actionData.orderFields[0].ToString(),
                    ObjectBase = new Service
                    {
                        Title = actionData.orderFields[1].ToString(),
                        Description = actionData.orderFields[2].ToString(),
                        CategoryItem = category,
                        Location = actionData.orderFields[4].ToString()
                    }
                });

            _dbContext.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        /// <summary>
        /// Обновляет объявление в базе данных по идентификатору <see cref="OrderBase.ID"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        // PUT api/order/5
        public void Put(int id, ActionData actionData)
        {
            OrderBase order = _dbContext.OrderBases.Find(id);

            order.ObjectBase.Title = actionData.orderFields[1].ToString();
            order.ObjectBase.Description = actionData.orderFields[2].ToString();
            order.ObjectBase.CategoryItem = _dbContext.CategoryItems.Find(actionData.orderFields[3]);
            order.ObjectBase.Location = actionData.orderFields[4].ToString();

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Удаляет объявление из базы данных по идентификатору <see cref="OrderBase.ID"/>
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/order/5
        //[Route("api/order/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            OrderBase order = _dbContext.OrderBases.Find(id);
            ObjectBase obj = _dbContext.ObjectBases.Find(id);

            if (order != null && obj != null)
            {
                _dbContext.OrderBases.Remove(order);
                _dbContext.ObjectBases.Remove(obj);
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
