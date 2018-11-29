using System.Web;
using System.Web.Mvc;

namespace SeunghwanKim_ASP.NET_Assignment2_Part1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
