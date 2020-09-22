using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Proyecciones
    {
        public int id { get; set; }
        public int idPresupuesto { get; set; }
        public DateTime incio_semana { get; set; }
        public DateTime final_semana { get; set; }
        public double gasto_estimado { get; set; }
    }
}
