using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class ProyectoGeneral
    {
        Temporadas Temporadas = new Temporadas();
        Detalle_granja detalle_Granja = new Detalle_granja();
        Proyecto Proyecto = new Proyecto();
        Detalle_proyecto Detalle_Proyecto = new Detalle_proyecto();
        public bool CrearProyecto(Proyecto Datosproyecto, List<string>ListNombreGranjas, DateTime f1,DateTime f2)
        {
            try
            {
                int IdDetalle = Detalle_Proyecto.AsignarId();
                if (Proyecto.Insertar(Datosproyecto))
                {

                    if (Proyecto.ResgistrarDetalle(IdDetalle, Proyecto.id, BuscarIdPorTemporadaCompleta(f1,f2)))
                    {
                        int idDetalleGranja = detalle_Granja.AsignarId();
                        if (Detalle_Proyecto.RegistrarDetalleGranja(idDetalleGranja, IdDetalle, HacerListaDeIDsPorNombre(ListNombreGranjas)))
                        {

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }
        private List<int> HacerListaDeIDsPorNombre(List<string> ListaNombres) 
        {
            Granja granja = new Granja();
            List<int> ListIdsGranja = new List<int>();
            foreach (var NombreGranja in ListaNombres)
            {
                var respuesta = granja.consultarInfoPorNombre(NombreGranja.Trim());
                if (respuesta!=null)
                {
                    ListIdsGranja.Add(respuesta.id);
                }
            }
            return ListIdsGranja;
        }
        private int BuscarIdPorTemporadaCompleta(DateTime FechaIni,DateTime FechaFin) 
        {
            return Temporadas.BuscarTemporadaPorFechas(FechaIni,FechaFin).id;
        }
    }
}
