using System.Web;
using System.Web.Mvc;

namespace WebAPI_CRUD_Methods
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
