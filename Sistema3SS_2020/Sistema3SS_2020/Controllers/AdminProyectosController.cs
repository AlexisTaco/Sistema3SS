using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema3SS_2020.Models;

namespace Sistema3SS_2020.Controllers
{
    public class AdminProyectosController : Controller
    {
        private Sistema3SSPruebasContext _context;

        public AdminProyectosController(Sistema3SSPruebasContext context)
        {
            this._context = context;
        }

        static int idProyecto;
        Presupuesto presupuesto = new Presupuesto();
        Proyecto proyecto = new Proyecto();
        Granja granja = new Granja();

        public ActionResult CrearProyecto()
        {
            try
            {
                Proyecto proyecto = new Proyecto();
                
                return View(proyecto);
            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }
        public ActionResult Index()
        {
            var granjas = _context.Granjas.ToList();
            ViewData["Granjas"] = new SelectList(granjas, "Id", "Nombre");

            ViewBag.Temporadas = _context.Temporadas.ToList();
            ViewBag.Proyectos = _context.Proyectos.Include(y => y.IdUsuarioNavigation).ToList().OrderBy(x => x.FechaInicial);

            return View();
        }

        
        [HttpPost]
        public void CrearProyecto(CreateProyecto proyecto)
        {
            try
            {
                Proyecto p = new Proyecto()
                {
                    FechaInicial = proyecto.FechaInicial,
                    FechaFinal = proyecto.FechaFinal,
                    IdUsuario = 3
                };
                
                _context.Proyectos.Add(p);
                _context.SaveChanges();

                DetalleProyecto dp = new DetalleProyecto()
                {
                    IdProyecto = p.Id,
                    IdTemporada = proyecto.IdTemporada
                };

                _context.DetalleProyectos.Add(dp);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }

        public class CreateProyecto {
            public DateTime FechaInicial { get; set; }
            public DateTime FechaFinal { get; set; }
            public int IdGranja { get; set; }
            public int IdTemporada { get; set; }
        }

    }
}
