using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWeb.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Contacto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guardar(FormCollection form)
        {
            string nombre = form["nombre"];
            ViewData["mensaje"] = "La informacion se guardo correctamente";
            return View("Index");
        }
    }
}