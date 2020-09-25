using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class GranjaController : Controller
    {
        Granja granja = new Granja();
        // GET: GranjaController
        public ActionResult Index()
        {
            return View(granja.MostrarLista());
        }

        // GET: GranjaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GranjaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GranjaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var gran = OrdenarColeccion(collection);
                if (granja.Insertar(gran))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: GranjaController/Edit/5
        public ActionResult Edit(int id)
        {
            var gran = granja.consultarInfoPorId(id);
            return View(gran);
        }

        // POST: GranjaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection keyValues)
        {
            try
            {
                var r = keyValues;
                var UsuOrd = OrdenarColeccion(r);
                var seActualizo = granja.actualizar(UsuOrd);
                if (seActualizo)
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

        // GET: GranjaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GranjaController/Delete/5
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
        private Granja OrdenarColeccion(IFormCollection collection)
        {
            this.granja.id = Convert.ToInt32(collection["id"]);
            this.granja.nombre = collection["nombre"].ToString();
            this.granja.ubicacion = collection["ubicacion"].ToString();
            this.granja.nombre_responsable = collection["nombre_responsable"].ToString();
            this.granja.apellido_materno_responsable = collection["apellido_materno_responsable"].ToString();
            this.granja.apellido_paterno_responsable = collection["apellido_paterno_responsable"].ToString();
            this.granja.numero_estanques = Convert.ToInt32(collection["numero_estanques"]);
            this.granja.perimetro_hetareas = Convert.ToDouble(collection["perimetro_hetareas"].ToString());
            return this.granja;


        }
    }
}
