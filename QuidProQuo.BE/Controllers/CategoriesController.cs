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
    public class CategoriesController : ApiController
    {
        QpqContext db = new QpqContext();

        // GET api/categories
        public IEnumerable<CategoryItem> Get()
        {
            return db.CategoryItems.ToList();
        }

        // GET api/categories/5
        public CategoryItem Get(int id)
        {
            return db.CategoryItems.Find(id);
        }

        // POST api/categories
        public void Post([FromBody]CategoryItem category)
        {
            db.CategoryItems.Add(category);
            db.SaveChanges();
        }

        // PUT api/categories/5
        public void Put(int id, [FromBody]CategoryItem category)
        {
            if (id == category.ID)
            {
                db.Entry(category).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/categories/5
        public void Delete(int id)
        {
            CategoryItem category = db.CategoryItems.Find(id);
            if (category != null)
            {
                db.CategoryItems.Remove(category);
                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
