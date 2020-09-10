using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Proyecto
    {
        Proyectos_repositorio proyectos_Repositorio = new Proyectos_repositorio();
        public int id { get; set; }
        public DateTime fecha_incial { get; set; }
        public DateTime fecha_final { get; set; }
        public int idUsuarioAutoriso { get; set; }
        public List<Granja> granjas { get; set; }
        public List<Temporadas> temporadas { get; set; }
        public List<int> Estanques { get; set; }

        public bool Insertar(Proyecto proyecto) 
        {
           var pro = proyectos_Repositorio.Insertar(proyecto);
            return pro;
        }







    }
}
