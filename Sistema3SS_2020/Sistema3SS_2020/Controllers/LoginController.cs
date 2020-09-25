using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class LoginController : Controller
    {
        private Sistema3SSPruebasContext _context;

        public LoginController(Sistema3SSPruebasContext context)
        {
            this._context = context;
        }

        // GET: LoginController
        public ActionResult Index()
        {

                return View();
        }

        public ActionResult Login(string nombre_usuario,string contrasena_usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario();
                var relogin = _context.Usuarios.Where(x => x.Contrasena == contrasena_usuario && x.CorreoElectronico == nombre_usuario).ToList();
                if (relogin.Count == 1)
                {
                    HttpContext.Session.SetString("NombreUsuario",nombre_usuario);
                    HttpContext.Session.SetString("ContrasenaUsuario", contrasena_usuario);
                    HttpContext.Session.SetString("IdUsuario", relogin[0].Id.ToString());

                    return   RedirectToAction("Principal", "Principal");

                }
                else
                {
                    return RedirectToAction("Index", "Principal");
                }
            }
            return RedirectToAction("Index", "Principal");
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
