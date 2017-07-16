using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoComercioPISO.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }
        /*
        // Editado
        [Route("~/redirecionar")]
        public ActionResult Redirecionar()
        {
            return RedirectToAction("Index");
        }

        //Partial
        [Route("~/partial")]
        public ActionResult Partial()
        {
            return PartialView("_LoginPartial");
        }
        */

        [Route("~/sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Essa é a descrição da minha aplicação";

            return View();
        }

        [HttpGet]
        [Route("~/contato")]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("~/contato")]
        public ActionResult Contact(FormCollection model)
        {
            return View();
        }
    }
}