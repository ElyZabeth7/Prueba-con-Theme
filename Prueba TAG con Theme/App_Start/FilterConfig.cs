using System.Web;
using System.Web.Mvc;

namespace Prueba_TAG_con_Theme
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
