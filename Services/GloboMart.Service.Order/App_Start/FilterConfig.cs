using System.Web;
using System.Web.Mvc;

namespace GloboMart.Service.Order
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
