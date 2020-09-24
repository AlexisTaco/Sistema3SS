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
        public List<SemanasTemporada> semanasTemporada; 
        public DateTime fecha_incial { get; set; }
        public DateTime fecha_final { get; set; }
        public int idUsuarioAutoriso { get; set; }
        public List<Granja> granjas { get; set; }
        public List<Temporadas> temporadas { get; set; }
        public List<Presupuesto> presupuestos { get; set; }
        public Detalle_proyecto detalle { get; set; }
        public Presupuesto presupuesto;
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
        public void BuscarSemanasTemporadasEnProyecto()
        {
            this.semanasTemporada = proyectos_Repositorio.BuscarSemanasTempo();
        }
        public List<SemanasTemporada> ListaDeSemanas { get; set; }
        public void CalularSemanasDeProyecto(DateTime FechaInicial,DateTime fechaFinal)
        {
            ////Primero calculamos los dias entre las dos fechas
            
            double dias = (fechaFinal - FechaInicial ).TotalDays;
            int count = 1;
            do
            {
                SemanasTemporada semana = new SemanasTemporada();
                if (count == 1)
                {
                    semana.fecha_inicial = FechaInicial;
                    semana.fecha_final = FechaInicial.AddDays(7);
                    dias = dias - 7;
                    count++;
                    ListaDeSemanas.Add(semana);
                }
                else
                {
                    semana.id = 1; //semana.AsignarId();
                    semana.fecha_inicial = FechaInicial.AddDays(7);
                    if (semana.fecha_inicial <= fechaFinal)
                    {
                        ListaDeSemanas.Add(semana);
                        dias = dias - 7;
                    }

                }



            } while (dias == 0);
        }












    }
}
