using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SANGUINARIOS.Controllers
{
    public class CitasController : Controller
    {
        // GET: Citas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RegistrosCita() 
            {
            return View();
            }
        public ActionResult ConsultasCita()
        {
            return View();
        }
    }
}