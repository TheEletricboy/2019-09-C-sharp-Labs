using System.Web;
using System.Web.Mvc;

namespace lab_just_do_it_dotnetframwork_api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
