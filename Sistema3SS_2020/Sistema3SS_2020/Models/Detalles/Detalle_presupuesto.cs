using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Detalle_presupuesto
    {
        Presupuesto_repositorio presupuesto_Repositorio = new Presupuesto_repositorio();
        public int id { get; set; }
        public int idPresupuesto;
        public int idConcepcion;
        public int idGranja;
        public int idProyecto;
        public int idGasto;
        public Presupuesto presupuesto { get; set; }
        public Proyecto proyecto { get; set; }
        public Concepcion concepcion { get; set; }
        public Granja granja { get; set; }
        public Concepto_gastos concepto_Gastos { get; set; }
        public Gastos gastos { get; set; }

        internal bool RegistrarDetalle( Presupuesto presupuesto)
        {
           return presupuesto_Repositorio.RegistrarDetallePresupuesto(presupuesto);
        }

        public void BuscarConcepcion(int ConcepcionId) 
        {
            this.concepcion = presupuesto_Repositorio.BuscarTiposConcepcionPorId(ConcepcionId);
        }
    }
}
