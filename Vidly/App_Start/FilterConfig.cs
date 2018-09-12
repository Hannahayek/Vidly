using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
            //this to prevent access without https/hence we need to change authtincation way  to enable SSL in proporties
            //also to change web uri in project proporty ,video 5:00
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
