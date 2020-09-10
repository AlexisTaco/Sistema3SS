using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Detalle_granja
    {
        public int id { get; set; }
        public int idProyecto { get; set; }
        public int idGranja { get; set; }
        public int numeroEstanque { get; set; }
    }
}
