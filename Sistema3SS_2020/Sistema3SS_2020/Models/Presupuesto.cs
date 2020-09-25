using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Presupuesto
    {
        Presupuesto_repositorio presupuesto_Repositorio = new Presupuesto_repositorio();
        public int id { get; set; }
        public List<Tipo_presupuesto> tipo_s { get; set; }
        public int IdTipo { get; set; }
        public int idProyecto { get; set; }
        public string NombreTipo;
        public double gasto_estimado_total_proyecciones_eco { get; set; }
        public double gasto_estimado_total_proyecciones_pro{ get; set; }
        public double total_presupuesto { get; set; }
        public Detalle_presupuesto detalle { get; set; }
        public Proyecciones Proyeccion { get; set; }
        public List<Gastos> TiposGastos { get; set; }
        public List<Detalle_presupuesto> Detalles { get; set; }
        public List<Concepcion> Concepciones { get; set; }
        public List<Concepto_gastos> Conceptos_gastos { get; set; }
        public Tipo_presupuesto TipoPrsupuesto { get; internal set; }
        public List<Tipo_presupuesto> BuscarTiposDePresupuesto()
        {
           return presupuesto_Repositorio.BuscarTiposPresupuesto();
        }
        internal Tipo_presupuesto buscarPorTipoPorId(int id)
        {
            return presupuesto_Repositorio.buscarPorTipoPorId(id);
        }
        public List<Concepcion> BuscarTiposDeConcepcion()
        {
            return presupuesto_Repositorio.BuscarTiposConcepcion();
        }
        public void SacarTotalPresupuestoEco(List<Presupuesto> PresupuestosEconomicos)
        {
            double total = 0;
            foreach (var pre in PresupuestosEconomicos)
            {
                if (pre.IdTipo == 1)
                {
                    total = total + SacarTotalProyeccion(pre.id);
                }
            }
            this.gasto_estimado_total_proyecciones_eco = total;
        }
        public void SacarTotalPresupuestoPro(List<Presupuesto> PresupuestoProduccion)
        {
            double total = 0;
            foreach (var pre in PresupuestoProduccion)
            {
                if (pre.IdTipo == 2)
                {
                    total = total + SacarTotalProyeccion(pre.id);
                }
            }
            this.gasto_estimado_total_proyecciones_pro = total;
        }
        public double SacarTotalProyeccion(int idPresupuesto)
        {
            double total = 0;
            var ProyeccionesEncontradas = Proyeccion.BuscarPorIdPresupuesto(idPresupuesto);
            foreach (var Pro in ProyeccionesEncontradas)
            {
                total = Pro.gasto_estimado + total;
            }
            return total;
        }

        public List<Gastos> BuscarTiposGastos()
        {
            return presupuesto_Repositorio.BuscarTiposGastos();
        }
        public List<Concepto_gastos> BuscarTiposConceptoGasto()
        {
            return presupuesto_Repositorio.BuscarTiposConceptos_gasto();
        }
        public List<Detalle_presupuesto> BuscarDetalles(int idPresupuesto) 
        {
            return presupuesto_Repositorio.BuscarDetallaPorIdProyecto(idPresupuesto);
        }
        internal Presupuesto buscar(int idPresupuesto)
        {
            return presupuesto_Repositorio.Buscar(idPresupuesto);
        }

    }
}
