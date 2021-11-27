using ServiTec.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ServiTec.webAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBibl seguridadBibl;
        public LoginController()
        {
            seguridadBibl = new SeguridadBibl();

        }

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            var nombreUsuario = data["Usuario"];
            var contrasena = data["contrasena"];
            var usuarioValido = seguridadBibl
            .Autorizar(nombreUsuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuario o contraseña invalidos");

            return View();
        }
    }
}