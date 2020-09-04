using Sistema3SS_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Insumos
    {
        Insumos_repositorio insumos_Repositorio = new Insumos_repositorio();
        public int id { get; set; }
        public int id_tipo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public double cantidad { get; set; }
        public List<Insumos> MostrarLista()
        {
            var list = insumos_Repositorio.MostarLista();
            return list;
        }
        public Insumos ConsultarInfoPorId(int id)
        {
            var r = insumos_Repositorio.ConsultarPorId(id);
            if (r != null)
            {
                return r;
            }
            else
            {
                return null;
            }
        }
        public bool actualizar(Insumos insumos)
        {
            var res = insumos_Repositorio.Actualizar(insumos, this.id);
            return res;
        }
        public bool Insertar(Insumos insumo)
        {
            var res = insumos_Repositorio.Insertar(insumo);
            return res;
        }
    }
}
