using System.Web;
using System.Web.Mvc;
using QuidProQuo.BE.Attributes;

namespace QuidProQuo.BE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new QAuthAtribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
