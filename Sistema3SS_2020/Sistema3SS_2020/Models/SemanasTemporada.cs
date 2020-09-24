using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class SemanasTemporada
    {
        public int id { get; set; }
        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_final { get; set; }

        internal SemanasTemporada buscarPorId(int id)
        {
            Presupuesto_repositorio presupuesto_Repositorio = new Presupuesto_repositorio();
            return presupuesto_Repositorio.buscarFechaSemanaPorId(id);
        }

        internal int AsignarId()
        {
            throw new NotImplementedException();
        }
    }
}
