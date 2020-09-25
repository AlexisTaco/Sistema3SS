using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Detalle_proyecto
    {
        Proyectos_repositorio proyectos_Repositorio = new Proyectos_repositorio();
        public int id { get; set; }
        public int idProyecto { get; set; }
        public int idTemporada { get; set; }
        public int idPresupuesto { get; set; }

        internal int AsignarId()
        {
            var id =  proyectos_Repositorio.AsignarIdDetalle();
            return id;

        }
    }
}
