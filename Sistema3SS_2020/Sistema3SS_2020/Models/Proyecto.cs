using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Proyecto
    {
        Granja granja = new Granja();
        Detalle_granja detalle_Granja = new Detalle_granja();
        Proyectos_repositorio proyectos_Repositorio = new Proyectos_repositorio();
        public int id { get; set; }
        public DateTime fecha_incial { get; set; }
        public DateTime fecha_final { get; set; }
        public int idUsuarioAutoriso { get; set; }
        public List<Granja> granjas { get; set; }
        public List<Temporadas> temporadas { get; set; }
        public Detalle_proyecto detalle { get; set; }
        public Presupuesto presupuesto { get; set; }
        internal bool ResgistrarDetalle(Detalle_proyecto detalle_Proyecto)
        {

            if (proyectos_Repositorio.InsertarDetalle(detalle_Proyecto))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<int> Estanques { get; set; }

        public bool Insertar(Proyecto proyecto) 
        {
           var pro = proyectos_Repositorio.Insertar(proyecto);
            return pro;
        }
        internal int AsignarId()
        {
            var id = proyectos_Repositorio.AsignarId();
            return id;
        }
        public List<Proyecto> MostrarLista()
        {
            var list = proyectos_Repositorio.MostarLista();
            return list;
        }
        public void BuscarDetallePorId(int idProyecto) 
        {
            detalle = proyectos_Repositorio.BuscarDetallePorIdPoryecto(idProyecto);
        }
        public void BuscarGranjasEnProyecto(int idProyecto) 
        {
            this.granjas = detalle_Granja.BuscarIdsGranjasPorIDproyecto(idProyecto);
        }










    }
}
