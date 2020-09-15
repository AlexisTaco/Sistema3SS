using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Temporadas
    {
        Proyectos_repositorio proyectos_Repositorio = new Proyectos_repositorio();
        public int id { get; set; }
        public DateTime fecha_inicial { get; set; }
        public DateTime fecha_final { get; set; }
        public List<Temporadas> BuascarTemporadas()
        {
            return proyectos_Repositorio.BuscarTemporadas();
        }
        public Temporadas BuscarTemporadaPorFechas(DateTime f1,DateTime f2) 
        {
            return proyectos_Repositorio.BuscarIdTemporadaPorfechas(f1,f2);
        }
    }
}
