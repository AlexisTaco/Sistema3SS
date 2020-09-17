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
        public bool CrearPresupuesto(Presupuesto _presupuesto,int idProyecto) 
        {

            var idAsiganda = Pre_repo.AsignarId();
            _presupuesto.id = idAsiganda;

            if (Pre_repo.RegistrarPresupuesto(_presupuesto))
            {
                _presupuesto.detalle.id = Pre_repo.AsignarIdDalle();
                if (Detalle_presu.RegistrarDetalle(_presupuesto) == true)
                {
                    if (_presupuesto.AgregarEnDetalleProyecto(idProyecto,_presupuesto.id))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
