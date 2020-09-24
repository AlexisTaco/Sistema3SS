using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Proyecciones
    {
        Presupuesto_repositorio presupuesto_Repositorio = new Presupuesto_repositorio();
        public int id { get; set; }
        public int idPresupuesto { get; set; }
        public int idSemana { get; set; }
        public DateTime incio_semana { get; set; }
        public DateTime final_semana { get; set; }
        public double gasto_estimado { get; set; }
        public List<Proyecciones> BuscarPorIdPresupuesto(int id)
        {
            return presupuesto_Repositorio.BuscarProyeccionPorIdPresupuesto(id);
        }
    }
}
