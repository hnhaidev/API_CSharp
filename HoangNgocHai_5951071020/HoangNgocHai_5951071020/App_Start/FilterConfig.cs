using System.Web;
using System.Web.Mvc;

namespace HoangNgocHai_5951071020
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
