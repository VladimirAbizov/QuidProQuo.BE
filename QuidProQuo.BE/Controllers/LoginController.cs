using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuidProQuo.BE.Attributes;
using QuidProQuo.BE.Models;

namespace QuidProQuo.BE.Controllers
{
    /// <summary>
    /// Контроллер позволяющий совершить вход в систему.
    /// </summary>
    public class LoginController : ApiController
    {
        private readonly QpqContext _dbContext = new QpqContext();

        public HttpResponseMessage Get(string login, string password)
        {
            var acount = _dbContext.Accounts.Where(x => x.Login == login);
            if (!acount.Any() || acount.Count() != 1)
            {
                throw new Exception("Не должно быть больше одного полбзователя!");
            }

            /// TODO В целевом решении, в случае успешной проходждении проверки, должен сгенерироваться ключ
            /// TODO в формате GUID со временем жизни и записаться в БД.
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(QAuthAtribute.ACCESS_TOKEN + ":" + QAuthAtribute.ACCESS_TOKEN_VALUE)
            };

            return httpResponseMessage;
        }
    }
}