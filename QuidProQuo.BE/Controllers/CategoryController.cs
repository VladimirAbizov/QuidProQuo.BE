using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    public class CategoryController : ApiController
    {
        public QpqContext _dbContext = new QpqContext();

        /// <summary>
        /// Возвращает список всех категорий <see cref="CategoryItem"/>
        /// </summary>
        // GET api/category
        public IEnumerable<CategoryItem> Get()
        {
            return _dbContext.CategoryItems.ToList();
        }

        /// <summary>
        /// Возвращает категорию <see cref="CategoryItem"/> по идентификатору <see cref="CategoryItem.ID"/>
        /// </summary>
        /// <param name="id"></param>
        // GET api/category/5
        public CategoryItem Get(int id)
        {
            return _dbContext.CategoryItems.Find(id);
        }

        /// <summary>
        /// Добавляет категорию <see cref="CategoryItem"/> в базу данных
        /// </summary>
        /// <param name="category"></param>
        // POST api/category
        public void Post([FromBody]CategoryItem category)
        {
            _dbContext.CategoryItems.Add(category);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Обновляет категорию <see cref="CategoryItem"/> в базе данных по идентификатору <see cref="CategoryItem.ID"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        // PUT api/category/5
        public void Put(int id, [FromBody]CategoryItem category)
        {
            if (id == category.ID)
            {
                _dbContext.Entry(category).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет категорию <see cref="CategoryItem"/> из базы данных по идентификатору <see cref="CategoryItem.ID"/>
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/category/5
        public void Delete(int id)
        {
            CategoryItem category = _dbContext.CategoryItems.Find(id);
            if (category != null)
            {
                _dbContext.CategoryItems.Remove(category);
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
