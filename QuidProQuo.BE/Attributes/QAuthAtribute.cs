using System.Web;
using System.Web.Http.Controllers;

namespace QuidProQuo.BE.Attributes
{
    /// <summary>
    /// Объект отвечающий за проверку авторизации пользователей в системе.
    /// </summary>
    public sealed class QAuthAtribute : System.Web.Http.AuthorizeAttribute
    {
        public const string ACCESS_TOKEN = "access_token";
        public const string ACCESS_TOKEN_VALUE = "{D603EAE7-6804-42F8-8332-5136C2EE20C9}";

        /// <summary>
        /// Метод проверки авторизации пользователя.
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var queryStringCollection = HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query);
            var token = queryStringCollection[ACCESS_TOKEN];
            if (!string.IsNullOrEmpty(token))
            {
                /// TODO В целевом решении мы должны будем обращаться к БД, брать из БД ключ и время жизни.
                if (string.CompareOrdinal(token, ACCESS_TOKEN_VALUE) == 0)
                {
                    return;
                }
            }

            HandleUnauthorizedRequest(actionContext);
        }
    }
}