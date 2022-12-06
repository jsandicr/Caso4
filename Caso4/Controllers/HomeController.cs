using Caso4.BaseDatos;
using Caso4.Models;
using Caso4.Models.Modelos;
using Caso4.Models.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caso4.Controllers
{
    public class HomeController : Controller
    {
        CobroModel cobroModel = new CobroModel();
        AbonoModel abonoModel = new AbonoModel();
        
        [HttpGet]
        public ActionResult Index()
        {
            var cobros = cobroModel.GetCobros().respuestaLista;
            ViewBag.Cobros = cobros;
            return View();
        }

        [HttpGet]
        public ActionResult Abono()
        {
            var cobros = cobroModel.GetCobros().respuestaLista;
            ViewBag.Cobros = cobros;
            return View();
        }

        [HttpPost]
        public ActionResult Abono(AbonoObj abono)
        {
            try {
                abonoModel.registrarAbono(abono);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Abono", "Home");
            }
        }
    }
}