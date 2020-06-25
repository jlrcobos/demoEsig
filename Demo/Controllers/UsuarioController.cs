using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;
namespace Demo.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Guardar(Usuario dto)
        {
            try
            {
                throw new Exception(" Sucedio un error");
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message =ex.Message });
            }
            return Json(new { success = true,message="Registro correcto" });
        }
    }
}