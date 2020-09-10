using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Detalle_proyecto
    {
        public int id { get; set; }
        public int idProyecto { get; set; }
        public int idTemporada { get; set; }
        public int idPresupuesto { get; set; }
    }
}
