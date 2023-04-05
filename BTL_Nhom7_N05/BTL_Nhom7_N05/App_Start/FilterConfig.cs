using System.Web;
using System.Web.Mvc;

namespace BTL_Nhom7_N05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
