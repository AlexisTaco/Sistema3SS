using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class AdminProyectosController : Controller
    {
        Proyecto proyecto = new Proyecto();
        public ActionResult CrearProyecto()
        {

            try
            {
                Temporadas temporadas = new Temporadas();
                Granja granja = new Granja();
                Proyecto proyecto = new Proyecto();
                proyecto.granjas = granja.MostrarLista();
                proyecto.temporadas = temporadas.BuascarTemporadas();
                return View(proyecto);
            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }
        // GET: AdminProyectos
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminProyectos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminProyectos/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearProyecto(IFormCollection collection)
        {
            try
            {
                var proyect = OrdenarColeccionProyecto(collection);
                if (proyect.Insertar(proyect))
                {

                }
                return View();
            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }
        // POST: AdminProyectos/Create
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

        // GET: AdminProyectos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminProyectos/Edit/5
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

        // GET: AdminProyectos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminProyectos/Delete/5
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
        private Proyecto OrdenarColeccionProyecto(IFormCollection collection)
        {
            this.proyecto.id = Convert.ToInt32(collection["id"]);
            this.proyecto.fecha_incial = Convert.ToDateTime(collection["nombre"].ToString());
            this.proyecto.fecha_final = Convert.ToDateTime(collection["ubicacion"].ToString());
            this.proyecto.idUsuarioAutoriso = Convert.ToInt32(collection["nombre_responsable"].ToString());
            return proyecto;


        }
    }
}
