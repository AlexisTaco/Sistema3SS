using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class TiposInsumo
    {
        public TiposInsumo()
        {
            Insumos = new HashSet<Insumo>();
        }

        public int Id { get; set; }
        public string Contexto { get; set; }
        public string Marca { get; set; }

        public virtual ICollection<Insumo> Insumos { get; set; }
    }
}
