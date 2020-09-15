using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Presupuesto
    {
        public int id { get; set; }
        public int Tipo { get; set; }
        public int idGasto { get; set; }
        public double total_presupuesto { get; set; }

    }
}
