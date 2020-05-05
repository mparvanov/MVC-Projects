using System.Web;
using System.Web.Mvc;

namespace MVC_Ajax_Post_Form
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
