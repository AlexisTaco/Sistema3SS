using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Detalle_granja
    {
       Granja_repositorio granja_Repositorio = new Granja_repositorio();
        public int id { get; set; }
        public int idProyecto { get; set; }
        public int idGranja { get; set; }
        public int numeroEstanque { get; set; }

        public int AsignarId()
        {
           return granja_Repositorio.AsignarIdDetalle();
        }
        internal bool Registrar(int idDetalleProyecto, List<int> idsGranjas)
        {

            if (InsertarDetalle(idDetalleProyecto, idsGranjas))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool InsertarDetalle(int idDetalleProyecto, List<int> idsGranjas)
        {
            
            bool res = false;
            foreach (var idGran in idsGranjas)
            {
                int idDetalle = AsignarId();
                if (granja_Repositorio.InsertarDetalle(idDetalle, idDetalleProyecto, idGran))
                {
                    res = true;
                }
                else
                {
                    return res = false;
                }
            }
            return true;
        }
        public List<Granja> BuscarIdsGranjasPorIDproyecto(int idProyecto) 
        {
            List<Granja> Granjas = new List<Granja>();
            var listDetallesGran = granja_Repositorio.MostarListaDetallesgranja(idProyecto);
            foreach (var item in listDetallesGran)
            {
                Granjas.Add(granja_Repositorio.ConsultarPorId(item.idGranja));
            }
           return Granjas;
        }
    }
}
