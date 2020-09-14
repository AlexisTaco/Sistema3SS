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
        Usuario usuario = new Usuario();
        public bool CrearProyecto(string nombreusu, string contrasenausu,Proyecto Datosproyecto, List<string>ListNombreGranjas,int idTemporada)
        {
            try
            {
                var usu = usuario.ConsultarInfoPorNombreycontrasena(nombreusu, contrasenausu);
                Datosproyecto.idUsuarioAutoriso = usu.id;
                Datosproyecto.id = Proyecto.AsignarId();
                if (Proyecto.Insertar(Datosproyecto))
                {
                    Detalle_Proyecto.id = Detalle_Proyecto.AsignarId();
                    Detalle_Proyecto.idTemporada = idTemporada;
                    Detalle_Proyecto.idProyecto = Datosproyecto.id;
                    if (Proyecto.ResgistrarDetalle(Detalle_Proyecto))
                    {
                        if (detalle_Granja.Registrar(Detalle_Proyecto.id, HacerListaDeIDsPorNombre(ListNombreGranjas)))
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
