using System.Web;
using System.Web.Mvc;

namespace ProyectoCine_Grupo3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
