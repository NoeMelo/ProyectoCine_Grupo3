using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoCine_Grupo3.Areas.Pelicula.Controllers
{
    public class MainController : Controller
    {
        // GET: Pelicula/Main
        public ActionResult Index()
        {
            return View();
        }
    }
}