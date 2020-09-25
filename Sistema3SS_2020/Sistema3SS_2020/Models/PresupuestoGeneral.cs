using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class PresupuestoGeneral
    {
        Presupuesto_repositorio Pre_repo = new Presupuesto_repositorio();
        Detalle_presupuesto Detalle_presu = new Detalle_presupuesto();
        Granja_repositorio granja_Repositorio = new Granja_repositorio();
        public bool CrearPresupuesto(Presupuesto _presupuesto,int idProyecto) 
        {

            var idAsiganda = Pre_repo.AsignarId();
            _presupuesto.id = idAsiganda;
            _presupuesto.idProyecto = idProyecto;

            if (Pre_repo.RegistrarPresupuesto(_presupuesto))
            {
                _presupuesto.detalle.id = Pre_repo.AsignarIdDalle();
                if (Detalle_presu.RegistrarDetalle(_presupuesto) == true)
                {
                    return true;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Presupuesto> BuscarInformacionPresupuestos(List<Detalle_presupuesto> detalles)
        {
            Concepcion concepcion = new Concepcion();
            Concepto_gastos concepto_Gastos = new Concepto_gastos();
            Granja granja = new Granja();
            Gastos gastos = new Gastos();
            List<Presupuesto> presupuestos = new List<Presupuesto>();
            foreach (var detalle_pres in detalles)
            {
                Presupuesto presupuesto = new Presupuesto();
                Detalle_presupuesto detalle = new Detalle_presupuesto();
                presupuesto = presupuesto.buscar(detalle_pres.idPresupuesto);
                presupuesto.detalle = detalle;
                presupuesto.detalle.concepcion = concepcion;
                presupuesto.detalle.concepto_Gastos = concepto_Gastos;
                presupuesto.detalle.granja = granja;
                presupuesto.detalle.gastos = gastos;
                ////////////////Hacer busqueda////////////////////
                presupuesto.detalle.gastos = Pre_repo.BuscarGastoPorId(detalle_pres.idGasto);
                presupuesto.detalle.concepto_Gastos = Pre_repo.BuscarConceptoGastoPorId(presupuesto.detalle.gastos.IdConcepto);
                presupuesto.detalle.granja = granja_Repositorio.BuscarPorId(detalle_pres.idGranja);
                presupuesto.detalle.concepcion = Pre_repo.BuscarTiposConcepcionPorId(detalle_pres.idConcepcion);
                presupuesto.TipoPrsupuesto = presupuesto.buscarPorTipoPorId(presupuesto.IdTipo);
                presupuesto.id = detalle_pres.idPresupuesto;
                presupuestos.Add(presupuesto);
            }
            return presupuestos;
        }

        internal bool RegistrarProyeccion(Proyecciones proyeccion)
        {
            return Pre_repo.RegistrarProyeccion(proyeccion);
        }

        internal int AsignarIdProyeccion()
        {
            return Pre_repo.AsignarIdProyecciones();
        }
    }
}
