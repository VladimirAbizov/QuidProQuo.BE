using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using QuidProQuo.BE.Models;
using System.Xml.Serialization;

namespace QuidProQuo.BE.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountController : ApiController
    {
        private readonly QpqContext _dbContext = new QpqContext();

        // GET api/account
        public IEnumerable<Account> Get()
        {
            return _dbContext.Accounts;
        }

        /// <summary>
        /// Возвращает аккаунт <see cref="Account"/> пользователя по идентификатору <see cref="Account.ID"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account Get(int id)
        {
            return _dbContext.Accounts.Find(id);
        }

        // POST api/account
        public void Post([FromBody]Account account)
        {
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
        }

        // PUT api/account/5
        public void Put(int id, [FromBody]Account account)
        {
            if (id == account.ID)
            {
                _dbContext.Entry(account).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }

        // DELETE api/account/5
        public void Delete(int id)
        {
            var account = _dbContext.Accounts.Find(id);
            if (account != null)
            {
                _dbContext.Accounts.Remove(account);
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
