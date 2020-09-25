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
        static int idProyecto;
        Presupuesto presupuesto = new Presupuesto();
        Proyecto proyecto = new Proyecto();
        Granja granja = new Granja();
        Gastos gastos = new Gastos();
        Proyecciones proyeccion = new Proyecciones();
        Detalle_presupuesto detalle_Presupuesto = new Detalle_presupuesto();
        #region Mostrar Presupuestos

        [HttpGet]
        public ActionResult listaDePresupuestos(int id)
        {
            PresupuestoGeneral presupuestoGeneral = new PresupuestoGeneral();
            List<Detalle_presupuesto> detalle_Presupuestos = new List<Detalle_presupuesto>();
            proyecto.BuscarSemanasTemporadasEnProyecto();
            presupuesto.Detalles = detalle_Presupuestos;
            proyecto.presupuesto = presupuesto;
            proyecto.presupuesto.Detalles = presupuesto.Detalles;
            proyecto.presupuesto.Detalles = presupuesto.BuscarDetalles(id);
            proyecto.presupuestos = presupuestoGeneral.BuscarInformacionPresupuestos(proyecto.presupuesto.Detalles);
            proyecto.presupuesto.Proyeccion = proyeccion;
            proyecto.presupuesto.SacarTotalPresupuestoEco(proyecto.presupuestos);
            proyecto.presupuesto.SacarTotalPresupuestoPro(proyecto.presupuestos);
            // proyecto.presupuesto.TipoPrsupuesto = 
            return View(proyecto);
        }

        #endregion
        #region CraearProyeccion
        [HttpPost]
        public ActionResult listaDePresupuestos(int id, IFormCollection collection, string CantidadProyeccion)
        {
            AgregarProyeccion(CantidadProyeccion, collection);
            return RedirectToAction(nameof(listaDePresupuestos));
        }
        public bool AgregarProyeccion(string CantidadProyectada, IFormCollection ProyeccionCollection)
        {
            PresupuestoGeneral presupuestoGeneral = new PresupuestoGeneral();

            Proyecciones proyecciones = new Proyecciones();
            proyecciones.id = presupuestoGeneral.AsignarIdProyeccion();
            proyecciones.idPresupuesto = Convert.ToInt32(ProyeccionCollection["presuID"]);
            proyecciones.idSemana = Convert.ToInt32(Convert.ToInt32(ProyeccionCollection["SelectSemana-" + proyecciones.idPresupuesto.ToString()]));
            var fecha = BuscarFechaSemana(Convert.ToInt32(Convert.ToInt32(ProyeccionCollection["SelectSemana-" + proyecciones.idPresupuesto.ToString()])));
            proyecciones.incio_semana = fecha.fecha_inicial;
            proyecciones.final_semana = fecha.fecha_final;
            proyecciones.gasto_estimado = Convert.ToDouble(CantidadProyectada);
            if (presupuestoGeneral.RegistrarProyeccion(proyecciones))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        SemanasTemporada BuscarFechaSemana(int id)
        {
            SemanasTemporada semanas = new SemanasTemporada();
            return semanas.buscarPorId(id);
        }
        #endregion
        #region Crear Presupuesto
        public ActionResult CrearPresupuesto()
        {
            Presupuesto presupuesto = new Presupuesto();
            Temporadas temporadas = new Temporadas();
            Proyecto proyecto = new Proyecto();
            proyecto.granjas = granja.MostrarLista();
            proyecto.temporadas = temporadas.BuascarTemporadas();
            proyecto.presupuesto = presupuesto;
            return View(proyecto);
        }
        [HttpPost]
        public ActionResult CrearPresupuesto(int id, IFormCollection Collections)
        {

            Detalle_presupuesto detalle_Presupuesto = new Detalle_presupuesto();
            try
            {
                PresupuestoGeneral presupuestoGeneral = new PresupuestoGeneral();
                Gastos gastos = new Gastos();
                Concepcion concepcion = new Concepcion();
                Concepto_gastos concepto_Gastos = new Concepto_gastos();

                //////////////////////////////////////////////////////////
                var idTipoPresupuesto = Collections["TipoPres"];
                var idGranja = Collections["SelectGranja"];
                var idConcepcion = Collections["SelectConcepcion"];
                var idConcepto = Collections["SelectConcepto"];
                var idGasto = Collections["SelectGasto"];
                //////////////////////////////////////////////////////////
                presupuesto.detalle = detalle_Presupuesto;
                presupuesto.detalle.granja = granja;
                presupuesto.detalle.concepto_Gastos = concepto_Gastos;
                presupuesto.detalle.concepcion = concepcion;
                presupuesto.detalle.gastos = gastos;
                ///////////////////////////////////////////////////////////
                presupuesto.detalle.granja.id = Convert.ToInt32(idGranja);
                presupuesto.IdTipo = Convert.ToInt32(idTipoPresupuesto);
                presupuesto.detalle.concepcion.id = Convert.ToInt32(idConcepcion);
                presupuesto.detalle.concepto_Gastos.id = Convert.ToInt32(idConcepto);
                presupuesto.detalle.gastos.id = Convert.ToInt32(idGasto);
                presupuestoGeneral.CrearPresupuesto(presupuesto, id);
                return RedirectToAction(nameof(CrearPresupuesto));
            }
            catch
            {
                return View();
            }
        }
        #endregion
        #region Crear Proyecto
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
        public ActionResult Index()
        {
            return View(proyecto.MostrarLista());
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public void CrearProyecto(IFormCollection collection)
        {
            try
            {
                ProyectoGeneral proyectoGeneral = new ProyectoGeneral();
                var usuname = HttpContext.Session.GetString("NombreUsuario");
                var usucont = HttpContext.Session.GetString("ContrasenaUsuario");
                var f1 = collection["fecha_incial"];
                var f2 = collection["fecha_final"];
                proyecto.fecha_incial = Convert.ToDateTime(f1);
                proyecto.fecha_final = Convert.ToDateTime(f2);
                proyecto.CalularSemanasDeProyecto(proyecto.fecha_incial, proyecto.fecha_final);
                var res = proyectoGeneral.CrearProyecto(usuname, usucont, proyecto, ListaNombresGranja(collection), Convert.ToInt32(collection["SelectTempo"]));
            }
            catch (Exception e)
            {
                var a = e.Message;
                throw;
            }
        }
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
        public ActionResult EnviarInfoPresupesto(int id)
        {

            try
            {
                idProyecto = id;
                return RedirectToAction("crearPresupuesto", "Principal");
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
        private Proyecto SepararFecha(string TemporadaCompleta)
        {
            Proyecto proyectoFech = new Proyecto();
            string[] Fechas = TemporadaCompleta.Split("-");
            proyectoFech.fecha_incial = Convert.ToDateTime(Fechas[1]);
            proyectoFech.fecha_final = Convert.ToDateTime(Fechas[2]);
            return proyectoFech;
        }
        #endregion


    }
}
