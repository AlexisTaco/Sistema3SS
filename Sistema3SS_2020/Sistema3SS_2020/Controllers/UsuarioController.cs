using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class UsuarioController : Controller
    {
        Usuario usuario = new Usuario(); 
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View(usuario.MostrarLista());
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var usu = OrdenarColeccion(collection);
                if (usuario.Insertar(usu))
                {
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            var usu =  usuario.ConsultarInfoPorId(id);
            return View(usu);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection keyValues)
        {
            try
            {
                var r = keyValues;
                var UsuOrd = OrdenarColeccion(r);
                var seActualizo =  usuario.actualizar(UsuOrd);
                if (seActualizo)
                {
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                var a = e.Message.Trim();
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
        private Usuario OrdenarColeccion(IFormCollection collection)
        {
            this.usuario.id = Convert.ToInt32(collection["id"]);
            this.usuario.nombre = collection["nombre"].ToString();
            this.usuario.apellido_paterno = collection["apellido_paterno"].ToString();
            this.usuario.apellido_materno = collection["apellido_materno"].ToString();
            this.usuario.contrasena = collection["contrasena"].ToString();
            this.usuario.correo_electronico = collection["correo_electronico"].ToString();
            this.usuario.id_tipo = Convert.ToInt32(collection["id_tipo"]);
            this.usuario.fecha_nacimiento = Convert.ToDateTime(collection["fecha_nacimiento"].ToString());
            this.usuario.numero_celular = collection["numero_celular"].ToString();
            this.usuario.direccion = collection["direccion"].ToString();
            var act = collection["act"].ToString().Trim(); 
            if (act == "true")
            {

                this.usuario.activo = true;
                return this.usuario;
            }
            else
            {
                this.usuario.activo = false;
                return this.usuario;
            }
            
            
        }
    }
}
