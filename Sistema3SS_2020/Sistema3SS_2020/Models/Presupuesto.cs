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
        public double total_presupuesto { get; set; }
        public Detalle_presupuesto detalle { get; set; }
        public List<Gastos> TiposGastos { get; set; }
        public List<Detalle_presupuesto> Detalles { get; set; }
        public List<Tipo_presupuesto> BuscarTiposDePresupuesto()
        {
           return presupuesto_Repositorio.BuscarTiposPresupuesto();
        }

        public List<Concepcion> BuscarTiposDeConcepcion()
        {
            return presupuesto_Repositorio.BuscarTiposConcepcion();
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
    }
}
