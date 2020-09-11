using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class AdminProyectosController : Controller
    {
        Proyecto proyecto = new Proyecto();
        Granja granja = new Granja();
        public ActionResult CrearProyecto()
        {

            try
            {
                Temporadas temporadas = new Temporadas();
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
            CrearProyecto(collection);
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
        private List<string> ListaNombresGranja(IFormCollection collectionForm) 
        {
            proyecto.granjas = granja.MostrarLista();
            List<string> ListaNombres = new List<string>();
                foreach (var granja in this.proyecto.granjas)
                {
                    string a = collectionForm[granja.nombre.ToString().Trim()];
                    if (a != null)
                    {
                       ListaNombres.Add(a);
                    }
                }
            return ListaNombres;
        }
        private void SepararFecha(string TemporadaCompleta)
        {
            string[] Fechas = TemporadaCompleta.Split("-");
            proyecto.fecha_incial = Convert.ToDateTime(Fechas[1]);
            proyecto.fecha_final = Convert.ToDateTime(Fechas[2]);
        }

    }
}
