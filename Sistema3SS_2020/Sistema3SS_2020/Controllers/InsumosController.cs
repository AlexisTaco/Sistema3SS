using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class InsumosController : Controller
    {
        Insumos ins = new Insumos();
        // GET: InsumosController
        public ActionResult Index()
        {
            return View(ins.MostrarLista()) ;
        }

        // GET: InsumosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InsumosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsumosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var ins = OrdenarColeccion(collection);
                if (ins.Insertar(ins))
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

        // GET: InsumosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InsumosController/Edit/5
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

        // GET: InsumosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InsumosController/Delete/5
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
        private Insumos OrdenarColeccion(IFormCollection collection)
        {
            this.ins.id = Convert.ToInt32(collection["id"]);
            this.ins.nombre = collection["nombre"].ToString();
            this.ins.unidad_medida = collection["unidad_medida"].ToString();
            this.ins.id_tipo = Convert.ToInt32(collection["id_tipo"]);
            this.ins.cantidad = Convert.ToDouble(collection["cantidad"].ToString());
            return this.ins;


        }
    }
}
