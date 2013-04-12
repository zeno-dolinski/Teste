using System.Web;
using System.Web.Mvc;

namespace Padrao.UI.Administrativo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}