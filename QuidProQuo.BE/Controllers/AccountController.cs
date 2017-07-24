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
    /// Содержит методы для работы с категориями <seealso cref="Models.CategoryItem"/>
    /// </summary>
    public class AccountController : ApiController
    {
        public QpqContext _dbContext = new QpqContext();

        /// <summary>
        /// Возвращает список аккаунтов <see cref="Account"/>
        /// </summary>
        // GET api/account
        public IEnumerable<Account> Get()
        {
            return _dbContext.Accounts.ToList();
        }

        /// <summary>
        /// Возвращает аккаунт <see cref="Account"/> пользователя по идентификатору <see cref="Account.ID"/>
        /// </summary>
        /// <param name="id"></param>
        // GET api/account/1 
        public Account Get(int id)
        {
            return _dbContext.Accounts.Find(id);
        }

        /// <summary>
        /// Добавляет аккаунт <see cref="Account"/> пользователя в базу данных
        /// </summary>
        // POST api/account
        public void Post([FromBody]Account account)
        {
            _dbContext.Accounts.Add(account);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Обновляет аккаунт <see cref="Account"/> пользователя в базе данных по идентификатору <see cref="Account.ID"/>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="account"></param>
        // PUT api/account/5
        public void Put(int id, [FromBody]Account account)
        {
            if (id == account.ID)
            {
                _dbContext.Entry(account).State = EntityState.Modified;

                _dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Удаляет аккаунт <see cref="Account"/> пользователя из базы данных по идентификатору <see cref="Account.ID"/>
        /// </summary>
        /// <param name="id"></param>
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
