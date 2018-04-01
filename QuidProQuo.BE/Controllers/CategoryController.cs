using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using QuidProQuo.BE.Attributes;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    [QAuthAtribute]
    public class CategoryController : ApiController
    {
        private readonly QpqContext _dbContext = new QpqContext();

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
        /// <param name="categoryType"></param>
        // GET api/category/service
        public IEnumerable<CategoryItem> Get(string categoryType)
        {
            if (categoryType == "service")
            {
                var res = _dbContext.CategoryItems.ToList().Where(x => x.categoryType == CategoryType.Service && x.IsCategory);
                return res;
            }
                
                else if (categoryType == "thing")
            {
                var res = _dbContext.CategoryItems.ToList().Where(x => x.categoryType == CategoryType.Thing && x.IsCategory);
                return res;
            }
                    else return null;
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
