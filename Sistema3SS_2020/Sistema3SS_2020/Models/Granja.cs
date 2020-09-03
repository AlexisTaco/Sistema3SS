using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Granja
    {
        Granja_repositorio granja_Repositorio = new Granja_repositorio();
        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string nombre_completo_responsable { get; set; }
        public string nombre_responsable { get; set; }
        public string apellido_paterno_responsable  { get; set; }
        public string apellido_materno_responsable { get; set; }
        public int numero_estanques { get; set; }
        public double perimetro_hetareas { get; set; }

        public List<Granja> MostrarLista() 
        {
            return granja_Repositorio.MostarLista();
        }
        public bool Insertar(Granja granja) 
        {
            var res = granja_Repositorio.Insertar(granja);
            return res;
        }

        public Granja consultarInfoPorId(int id)
        {
            var r = granja_Repositorio.ConsultarPorId(id);
            if (r != null)
            {
                return r;
            }
            else
            {
                return null;
            }
        }
        public bool actualizar(Granja gran)
        {
            var res = granja_Repositorio.Actualizar(gran, this.id);
            return res;
        }

    }
}
